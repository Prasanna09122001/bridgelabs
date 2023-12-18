using FundooModel.Notes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.IManager
{
    public interface ICollabManager
    {
        public Task<int> AddCollaborator(Collobrator collaborator);
        public bool DeleteCollab(int noteId, int userId);
        public IEnumerable<Collobrator> GetAllCollabNotes(int userId);
        public IEnumerable<NotesCollab> GetAllNotesColllab(int userId);
    }
}
