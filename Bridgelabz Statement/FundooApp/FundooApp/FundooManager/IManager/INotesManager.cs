using FundooModel.Notes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.IManager
{
    public interface INotesManager
    {
        public Task<int> AddNotes(Note note);
        public Note EditNotes(Note note);
        public IEnumerable<Note> GetAllNotes(int id);
        public bool DeleteNote(int noteid);
        public IEnumerable<Note> GetArcheived(int id);
        public IEnumerable<Note> GetPinnedNote(int id);
        public IEnumerable<Note> GetThrashedNote(int id);
        public bool TrashNote(int id,int noteid);
        public Note ArcheiveNote(int noteId, int id);
        public Note PinNote(int noteId, int id);
        public bool RestoreNote(int noteId, int id);
        public string Image(IFormFile file, int noteId);
        public Note GetNoteById(int userId, int noteId);
        public IEnumerable<Note> GetRemainderTask(int userid);
        public Task<int> CreateCopyNote(int userId, int noteId);
    }

}
