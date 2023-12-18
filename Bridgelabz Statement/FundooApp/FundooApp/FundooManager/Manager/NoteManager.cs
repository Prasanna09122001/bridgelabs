using FundooManager.IManager;
using FundooModel.Notes;
using FundooRepo.IRepository;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Manager
{
    public class NoteManager : INotesManager
    {
        public readonly INotesRepository NotesRepository;
        public NoteManager(INotesRepository NotesRepository)
        {
            this.NotesRepository = NotesRepository;
        }
        public Task<int> AddNotes(Note note)
        {
            var result = this.NotesRepository.AddNotes(note);
            return result;
        }
        public Note EditNotes(Note note)
        {
            var result = this.NotesRepository.EditNotes(note);
            return result;
        }
        public IEnumerable<Note> GetAllNotes(int id)
        {
            var result = this.NotesRepository.GetAllNotes(id);
            return result;
        }
        public bool DeleteNote(int noteid)
        {
            var result = this.NotesRepository.DeleteNote(noteid);
            return result;
        }
        public IEnumerable<Note> GetArcheived(int id)
        {
            var result = this.NotesRepository.GetArcheived(id);
            return result;
        }
        public IEnumerable<Note> GetPinnedNote(int id)
        {
            var result = this.NotesRepository.GetPinnedNote(id);
            return result;
        }
        public IEnumerable<Note> GetThrashedNote(int id)
        {
            var result = this.NotesRepository.GetThrashedNote(id);
            return result;
        }
        public bool TrashNote(int id,int noteid)
        {
            var result = this.NotesRepository.TrashNote(id,noteid);
            return result;
        }
        public Note ArcheiveNote(int noteId, int id)
        {
            var result = this.NotesRepository.ArcheiveNote(noteId, id);
            return result;
        }
        public Note PinNote(int noteId, int id)
        {
            var result = this.NotesRepository.PinNote(noteId, id);
            return result;
        }
        public bool RestoreNote(int noteId, int id)
        {
            var result = this.NotesRepository.RestoreNote(noteId, id);
            return result;
        }
        public string Image(IFormFile file, int noteId)
        {
            var result = this.NotesRepository.Image(file, noteId);
            return result;
        }
        public Note GetNoteById(int userId, int noteId)
        {
            var result = this.NotesRepository.GetNoteById(userId, noteId);
            return result;
        }
        public IEnumerable<Note> GetRemainderTask(int userid)
        {
            var result = this.NotesRepository.GetRemainderTask(userid);
            return result;
        }
        public Task<int> CreateCopyNote(int userId, int noteId)
        {
            var result = this.NotesRepository.CreateCopyNote(userId, noteId);
            return result;
        }
    
    }
}
