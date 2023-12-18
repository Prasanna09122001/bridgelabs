using FundooManager.IManager;
using FundooModel.Notes;
using FundooRepo.IRepository;
using FundooRepo.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Manager
{
    public class CollabManager : ICollabManager
    {
        public readonly ICollabRepository CollabRepository;
        public CollabManager(ICollabRepository CollabRepository)
        {
            this.CollabRepository = CollabRepository;
        }
        public Task<int> AddCollaborator(Collobrator collaborator)
        {
            var result = this.CollabRepository.AddCollaborator(collaborator);
            return result;
        }
        public bool DeleteCollab(int noteId, int userId)
        {
            var result = this.CollabRepository.DeleteCollab(noteId, userId);
            return result;
        }
        public IEnumerable<Collobrator> GetAllCollabNotes(int userId)
        {
            var result = this.CollabRepository.GetAllCollabNotes(userId);
            return result;
        }
        public IEnumerable<NotesCollab> GetAllNotesColllab(int userId)
        {
            var result = this.CollabRepository.GetAllNotesColllab(userId);
            return result;
        }
    }
}
