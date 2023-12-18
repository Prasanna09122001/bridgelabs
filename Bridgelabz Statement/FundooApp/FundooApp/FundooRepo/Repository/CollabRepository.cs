using FundooModel.Notes;
using FundooRepo.Context;
using FundooRepo.IRepository;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using NLogImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepo.Repository
{
    public class CollabRepository : ICollabRepository
    {
        public readonly UserDbContext context;
        NlogOperation NLog = new NlogOperation();
        private readonly IDistributedCache distributedCache;
        public CollabRepository(UserDbContext context, IDistributedCache distributedCache)
        {
            this.context = context;
            this.distributedCache = distributedCache;
        }
        public Task<int> AddCollaborator(Collobrator Collobrator)
        {
            this.context.Collobrator.Add(Collobrator);
            var result = this.context.SaveChangesAsync();
            NLog.LogInfo("Collobrator Added Successfully");
            return result;
        }
        public bool DeleteCollab(int noteId, int userId)
        {
            var result = this.context.Collobrator.Where(x => x.NoteId == noteId && x.ReceiverUserId == userId).FirstOrDefault();
            if (result != null)
            {
                this.context.Collobrator.Remove(result);
                var deleteResult = this.context.SaveChanges();
                if (deleteResult == 1)
                {
                    NLog.LogInfo("Collobrator Deleted Successfully");
                    return true;
                }
            }
            NLog.LogWarn("Collobrator Deleted UnSuccessful");
            return false;
        }
        public IEnumerable<Collobrator> GetAllCollabNotes(int userId)
        {
            var result = this.context.Collobrator.Where(x => x.SenderUserId == userId || x.ReceiverUserId == userId).AsEnumerable();
            if (result != null)
            {
                this.PutListToCache(userId);
                return result;
            }
            var data = this.GetListFromCache("CollabList");
            return null;
        }
        public IEnumerable<NotesCollab> GetAllNotesColllab(int userId)
        {
            List<NotesCollab> collab = new List<NotesCollab>();
            var result = this.context.Note.Join(this.context.Collobrator.Where(X=> X.SenderUserId ==  userId),
                Note => Note.NoteId,
                Collaborator => Collaborator.NoteId,
                (Note, Collaborator) => new NotesCollab
                {
                    NoteId = Note.NoteId,
                    Title = Note.Title,
                    Description = Note.Description,
                    Image = Note.Image,
                    Color = Note.Color,
                    Remainder = Note.Remainder,
                    IsArchive = Note.IsArchive,
                    IsPin = Note.IsPin,
                    IsTrash = Note.IsTrash,
                    CreatedDate = Note.CreatedDate,
                    CollabId = Collaborator.CollabId,
                    SenderUserId =Collaborator.SenderUserId,
                    ReceiverUserId = Collaborator.ReceiverUserId                    
                });
            foreach (var data in result)
            {
                if (data.SenderUserId == userId || data.ReceiverUserId == userId)
                {
                    collab.Add(data);
                }
            }
            NLog.LogInfo("Dispalyed All Collab Notes Successfully");
            return result;
        }
        public void PutListToCache(int userid)
        {
            var options = new DistributedCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(60));
            var enlist = this.context.Collobrator.Where(x => x.SenderUserId == userid || x.ReceiverUserId == userid);
            var jsonstring = JsonConvert.SerializeObject(enlist);
            distributedCache.SetString("CollabList", jsonstring, options);
        }
        public List<Note> GetListFromCache(string key)
        {
            var CacheString = this.distributedCache.GetString(key);
            return JsonConvert.DeserializeObject<IEnumerable<Note>>(CacheString).ToList();
        }
    }
}
