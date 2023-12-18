using FundooModel.Labels;
using FundooModel.Notes;
using FundooModel.User;
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
    public class LabelRepository : ILabelRepository
    {
        public readonly UserDbContext context;
        NlogOperation nlog = new NlogOperation();
        private readonly IDistributedCache distributedCache;
        public LabelRepository(UserDbContext context, IDistributedCache distributedCache)
        {
            this.context = context;
            this.distributedCache = distributedCache;
        }
        public Task<int> AddLabels(Label labels)
        {
            this.context.Labels.Add(labels);
            var result = this.context.SaveChangesAsync();
            nlog.LogInfo("Label Added Successfully");
            return result;
        }
        public Label EditLabel(Label labels)
        {
            var data = this.context.Labels.Where(x => x.LabelId == labels.LabelId).FirstOrDefault();
            if (data != null)
            {
                data.LabelId = labels.LabelId;
                data.LabelName = labels.LabelName;
                nlog.LogInfo("Label Edited successful");
                return data;
            }
            nlog.LogWarn("No labels found");
            return null;
        }
        public IEnumerable<Label> GetAllLabels(int userid)
        {
            var result = this.context.Labels.Where(x => x.Id == userid).AsEnumerable();
            if (result != null)
            {
                this.PutListToCache(userid);
                return result;
            }
            var data = this.GetListFromCache("LabelList");
            return null;
        }

        public IEnumerable<Label> GetAllLabelNotes(int userid)
        {
            List<Label> list = new List<Label>();
            var result = this.context.Labels.Where(x => x.Id.Equals(userid)).Join(this.context.Note,
                Label => Label.NoteId,
                Note => Note.NoteId,
               (Label, Note) => new Label
               {
                   LabelId = Label.LabelId,
                   LabelName = Label.LabelName,
                   NoteId = Label.NoteId,
                   Note = Note,
                   Id = Label.Id
               });
            nlog.LogInfo("Displayed All Label Notes Successfully");
                return result; 
        }

        public bool DeleteLabels(int userid)
        {
            var result = this.context.Labels.Where(x => x.LabelId == userid).ToList();
            foreach (var data in result)
            {
                nlog.LogInfo("Deleted label successfully");
                this.context.Labels.Remove(data);
            }
            var deleteResult = this.context.SaveChanges();
            if (deleteResult == 0)
            {
                nlog.LogWarn("There is No Label Found");
                return false;
            }
            nlog.LogWarn("There is No Label Found");
            return false;
        }
        public void PutListToCache(int userid)
        {
            var options = new DistributedCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(60));
            var enlist = this.context.Labels.Where(x => x.Id == userid);
            var jsonstring = JsonConvert.SerializeObject(enlist);
            distributedCache.SetString("LabelList", jsonstring, options);
        }
        public List<Note> GetListFromCache(string key)
        {
            var CacheString = this.distributedCache.GetString(key);
            return JsonConvert.DeserializeObject<IEnumerable<Note>>(CacheString).ToList();
        }
    }
}
