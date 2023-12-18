using FundooModel.Notes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using FundooManager.IManager;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace FundooApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize]
    public class NotesController : ControllerBase
    {
        public readonly INotesManager NoteManager;
        public NotesController(INotesManager NoteManager)
        {
            this.NoteManager = NoteManager;
        }
        [HttpPost]
        [Route("Add Note")]
        public async Task<ActionResult> AddNotes(Note note)
        {
            try
            {
                var result = await this.NoteManager.AddNotes(note);
                if (result == 1)
                {
                    return this.Ok(new { Status = true, Message = "Adding Notes Successful", data = note });
                }
                return this.BadRequest(new { Status = false, Message = "Adding Notes UnSuccessful" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }
        [HttpPut]
        [Route("Edit Note")]
        public ActionResult EditNotes(Note note)
        {
            try
            {
                var result = this.NoteManager.EditNotes(note);
                if (result != null)
                {
                    return this.Ok(new { Status = true, Message = "Edit Task Successful", data = note });
                }
                return this.BadRequest(new { Status = false, Message = "Edit Task UnSuccessful" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }
        [HttpPut]
        [Route("Delete Note")]
        public ActionResult DeleteNote(int noteid)
        {
            try
            {
                var result = this.NoteManager.DeleteNote(noteid);
                if (result != null)
                {
                    return this.Ok(new { Status = true, Message = "Deleted Successful" });
                }
                return this.BadRequest(new { Status = false, Message = "Deleted UnSuccessful" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("Get All Notes")]
        public async Task<ActionResult> GetAllNotes(int id)
        {
            try
            {
                var result = this.NoteManager.GetAllNotes(id);
                if (result != null)
                {
                    return this.Ok(new { Status = true, Message = "Notes Found", data = result });
                }
                return this.BadRequest(new { Status = false, Message = "No Notes Found" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("Get Notes By Id")]
        public async Task<ActionResult> GetNoteById(int userId, int noteId)
        {
            try
            {
                var result = this.NoteManager.GetNoteById(userId, noteId);
                if (result != null)
                {
                    return this.Ok(new { Status = true, Message = "Notes Found", data = result });
                }
                return this.BadRequest(new { Status = false, Message = "No Notes Found" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("Get All Archeived Notes")]
        public async Task<ActionResult> GetArcheived(int id)
        {
            try
            {
                var result = this.NoteManager.GetArcheived(id);
                if (result != null)
                {
                    return this.Ok(new { Status = true, Message = "Notes Found", data = result });
                }
                return this.BadRequest(new { Status = false, Message = "No Notes Found" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("Get All Pin Notes")]
        public async Task<ActionResult> GetPinnedTask(int id)
        {
            try
            {
                var result = this.NoteManager.GetPinnedNote(id);
                if (result != null)
                {
                    return this.Ok(new { Status = true, Message = "Notes Found", data = result });
                }
                return this.BadRequest(new { Status = false, Message = "No Notes Found" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("Get All Deleted Notes")]
        public async Task<ActionResult> GetThrashedTask(int id)
        {
            try
            {
                var result = this.NoteManager.GetThrashedNote(id);
                if (result != null)
                {
                    return this.Ok(new { Status = true, Message = "Notes Found", data = result });
                }
                return this.BadRequest(new { Status = false, Message = "No Notes Found" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }
        [HttpDelete]
        [Route("Delete All Trashed Note")]
        public async Task<ActionResult> TrashNote(int id, int noteid)
        {
            try
            {
                var result = this.NoteManager.TrashNote(id,noteid);
                if (result != null)
                {
                    return this.Ok(new { Status = true, Message = "Notes Deleted Permantely" });
                }
                return this.BadRequest(new { Status = false, Message = "No Notes Found" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }
        [HttpPut]
        [Route("Archeive The Note")]
        public ActionResult ArcheiveNote(int noteid, int id)
        {
            try
            {
                var result = this.NoteManager.ArcheiveNote(noteid, id);
                if (result != null)
                {
                    return this.Ok(new { Status = true, Message = "Note Archeived Successful", data = result });
                }
                return this.BadRequest(new { Status = false, Message = "Note Archeived UnSuccessful" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }
        [HttpPut]
        [Route("Pin the Note")]
        public ActionResult PinNote(int noteid, int id)
        {
            try
            {
                var result = this.NoteManager.PinNote(noteid, id);
                if (result != null)
                {
                    return this.Ok(new { Status = true, Message = "Note Pinned Successful", data = result });
                }
                return this.BadRequest(new { Status = false, Message = "Note Pinned UnSuccessful" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }
        [HttpPut]
        [Route("Restore Note")]
        public ActionResult RestoreNote(int noteid, int id)
        {
            try
            {
                var result = this.NoteManager.RestoreNote(noteid, id);
                if (result != null)
                {
                    return this.Ok(new { Status = true, Message = "Note Restored Successful" });
                }
                return this.BadRequest(new { Status = false, Message = "Note Restored UnSuccessful" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }
        [HttpPut]
        [Route("UploadImage")]
        public ActionResult Image(IFormFile file, int noteId)
        {
            try
            {
                var result = this.NoteManager.Image(file, noteId);
                if (result != null)
                {
                    return this.Ok(new { Status = true, Message = "Image Added Successful" });
                }
                return this.BadRequest(new { Status = false, Message = "Image Added UnSuccessful" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("Get All Remainder Notes")]
        public async Task<ActionResult> GetRemainderTask(int Userid)
        {
            try
            {
                var result = this.NoteManager.GetRemainderTask(Userid);
                if (result != null)
                {
                    return this.Ok(new { Status = true, Message = "Notes Found", data = result });
                }
                return this.BadRequest(new { Status = false, Message = "No Notes Found" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("CreateCopyNote")]
        public async Task<ActionResult> CreateCopyNote(int userId, int noteId)
        {
            try
            {
                var result = await this.NoteManager.CreateCopyNote(userId, noteId);
                if (result == 1)
                {
                    return this.Ok(new { Status = true, Message = "Adding Notes Successful"});
                }
                return this.BadRequest(new { Status = false, Message = "Adding Notes UnSuccessful" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }
    }
}
