using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using FundooModel.Notes;
using FundooRepo.Context;
using FundooRepo.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using NLog.Time;
using NLogImplementation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepo.Repository
{
    public class NotesRepository : INotesRepository
    {
        public readonly UserDbContext context;
        NlogOperation log = new NlogOperation();
        private readonly IDistributedCache distributedCache;
        public NotesRepository(UserDbContext context, IDistributedCache distributedCache)
        {
            this.context = context;
            this.distributedCache = distributedCache;
        }
        public Task<int> AddNotes(Note note)
        {
            try
            {
                this.context.Note.Add(note);
                var result = this.context.SaveChangesAsync();
                log.LogInfo("Notes Addeed Successfully");
                return result;
            }
            catch (Exception ex)
            {
                log.LogError(ex.Message);
                return null;
            }
        }
        public Note EditNotes(Note note)
        {
            try
            {
                var data = this.context.Note.Where(x => x.NoteId == note.NoteId).FirstOrDefault();
                if (data != null)
                {
                    data.Id = note.Id;
                    data.Remainder = note.Remainder;
                    data.Title = note.Title;
                    data.Color = note.Color;
                    data.ModifiedDate = note.ModifiedDate;
                    //data.CreatedDate = note.CreatedDate;
                    data.Description = note.Description;
                    data.Image = note.Image;
                    data.IsArchive = note.IsArchive;
                    data.IsPin = note.IsPin;
                    data.IsTrash = note.IsTrash;
                    this.context.Note.Update(data);
                    this.context.SaveChangesAsync();
                    log.LogInfo("Note Updated Sucessfully");
                    return data;
                }
                log.LogWarn("Your Id or Email Id is Incorrect");
                return null;
            }
            catch (Exception ex)
            {
                log.LogError(ex.Message);
                return null;
            }
        }
        public IEnumerable<Note> GetAllNotes(int id)
        {
            var result = this.context.Note.Where(x => x.Id == id && x.IsTrash==false && x.IsArchive == false).AsEnumerable();
            WriteToJsonFile(result.ToList());
            if (result != null)
            {
                this.PutListToCache(id);
                return result;
            }
            var data = this.GetListFromCache("noteList");
            return null;
        }
        public Note GetNoteById(int userId, int noteId)
        {
            var data = this.GetListFromCache("noteList");
            if(data != null)
            {
                return data.Where(x => x.Id == userId && x.NoteId == noteId).FirstOrDefault();
            }
            else
            {
                var result = this.context.Note.Where(x => x.Id == userId && x.NoteId == noteId).FirstOrDefault();
                return result;
            }
        }
        public bool DeleteNote(int noteid)
        {
            try
            {
                var result = this.context.Note.Where(x => x.NoteId == noteid).FirstOrDefault();
                if (result != null)
                {
                    result.IsTrash = true;
                    this.context.Note.Update(result);
                    var deleteResult = this.context.SaveChanges();
                    if (deleteResult == 1)
                    {
                        log.LogInfo("Your Note is Added to the Thrash");
                        return true;
                    }
                    log.LogWarn("Your Note is Not Added to the Thrash");
                    return false;
                }
                log.LogWarn("Given Mail id or Note Id is Wrong");
                return false;
            }
            catch (Exception ex)
            {
                log.LogError(ex.Message);
                return false;
            }
        }
        public IEnumerable<Note> GetThrashedNote(int id)
        {
             var result = this.context.Note.Where(x => x.Id == id && x.IsTrash == true).AsEnumerable();
              return result;
            
        }
        public bool TrashNote(int id,int noteid)
        {
            try
            {
                var result = this.context.Note.Where(x => x.Id == id && x.IsTrash == true).ToList();
                foreach (var data in result)
                {
                    if (data.NoteId == noteid)
                    {
                        this.context.Note.Remove(data);
                    }
                }
                var deleteResult = this.context.SaveChanges();
                if (deleteResult == 0)
                {
                    log.LogInfo("Your Thrashed Note are Deleted Permanetly");
                    return false;
                }
                log.LogWarn("There is No Thrash Note in the Given Mail Id");
                return false;
            }
            catch (Exception ex)
            {
                log.LogError(ex.Message);
                return false;
            }
        }
        public Note PinNote(int noteId, int id)
        {
            try
            {
                var result = this.context.Note.Where(x => x.NoteId == noteId && x.Id == id).FirstOrDefault();
                if (result != null)
                {
                    result.IsPin = true;
                    this.context.Note.Update(result);
                    this.context.SaveChangesAsync();
                    log.LogInfo("Your Note is Pinned Successfully");
                    return result;
                }
                log.LogWarn("Given Mail Id or Note Id is Incorrect");
                return null;
            }
            catch (Exception ex)
            {
                log.LogError(ex.Message);
                return null;
            }
        }
        public IEnumerable<Note> GetArcheived(int id)
        {
              var result = this.context.Note.Where(x => x.Id == id && x.IsArchive == true).AsEnumerable();
              return result;
           
        }
        public Note ArcheiveNote(int noteId, int id)
        {
            try
            {
                var result = this.context.Note.Where(x => x.NoteId == noteId && x.Id == id).FirstOrDefault();
                if (result != null)
                {
                    if (result.IsArchive == true)
                    {
                        result.IsArchive = false;
                    }
                    else
                    {
                        result.IsArchive = true;
                    }
                    this.context.Note.Update(result);
                    this.context.SaveChangesAsync();
                    log.LogInfo("Your Note is Archeived Successfully");
                    return result;
                }
                log.LogWarn("Given Mail id or Note Id is Incorrect");
                return null;
            }
            catch (Exception ex)
            {
                log.LogError(ex.Message);
                return null;
            }
        }
        public IEnumerable<Note> GetPinnedNote(int id)
        {
                var result = this.context.Note.Where(x => x.Id == id && x.IsPin == true).AsEnumerable();
                return result;
        }
        public bool RestoreNote(int noteId, int id)
        {
            try
            {
                var result = this.context.Note.Where(x => x.NoteId == noteId && x.Id == id).FirstOrDefault();
                if (result != null)
                {
                    result.IsTrash = false;
                    this.context.Note.Update(result);
                    this.context.SaveChanges();
                    log.LogInfo("Your Note is Restored Successfully");
                    return true;
                }
                log.LogWarn("Given Mail Id and Note Id is Incorrect");
                return false;
            }
            catch (Exception ex)
            {
                log.LogError(ex.Message);
                return false;
            }

        }
        public string Image(IFormFile file,int noteId)
        {
            try
            {
                if(file == null)
                {
                    return null;
                }
                var stream = file.OpenReadStream();
                var name = file.FileName;
                Account account = new Account("doiyb9hon", "573891546948353", "tLXRI6E-Ux9KUhczlLgknbDmcwQ");
                Cloudinary cloudinary = new Cloudinary(account);
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(name, stream)
                };
                ImageUploadResult uploadResult = cloudinary.Upload(uploadParams);
                cloudinary.Api.UrlImgUp.BuildUrl(String.Format("{0}.{1}", uploadResult.PublicId, uploadResult.Format));
                var data = this.context.Note.Where(t => t.NoteId == noteId).FirstOrDefault();
                data.Image = uploadResult.Uri.ToString();
                var result = this.context.SaveChanges();
                log.LogInfo("Image Added Successfully");
                return data.Image;
            }
            catch(Exception ex)
            {
                log.LogWarn(ex.Message);
                return ex.Message;
            }
        }
        public void PutListToCache (int userid)
        {
            var options = new DistributedCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(60));
            var enlist = this.context.Note.Where(x => x.Id == userid);
            var jsonstring = JsonConvert.SerializeObject(enlist);
            distributedCache.SetString("noteList", jsonstring, options);
        }
        public List<Note> GetListFromCache(string key)
        {
            var CacheString = this.distributedCache.GetString(key);
            return JsonConvert.DeserializeObject<IEnumerable<Note>>(CacheString).ToList();
        }
        public IEnumerable<Note> GetRemainderTask(int userid)
        {
                var result = this.context.Note.Where(x => x.Id == userid && x.Remainder != null).AsEnumerable();
                return result;
            
        }
        public Task<int> CreateCopyNote(int userId, int noteId)
        {
            var data = this.context.Note.Where(x => x.Id == userId && x.NoteId == noteId).FirstOrDefault();
            var note = new Note
            {
                Title = data.Title,
                Description = data.Description,
                Image = data.Image,
                Color = data.Color,
                Remainder = data.Remainder,
                IsArchive = data.IsArchive,
                IsPin = data.IsPin,
                IsTrash = data.IsTrash,
                CreatedDate = data.CreatedDate,
                ModifiedDate = data.ModifiedDate,
                Id = data.Id,
            };
            var result = this.AddNotes(note);
           return result;
        }
        public void WriteToJsonFile(List<Note> Note)
        {
            string filepath = @"D:\Bridgelabz Statement\FundooApp\FundooApp\NLogImplementation\Notes.json";
            var json = JsonConvert.SerializeObject(Note);
            File.WriteAllText(filepath, json);
        }
    }
}
