using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using FundooManager.IManager;
using FundooModel.Labels;
using Microsoft.AspNetCore.Authorization;

namespace FundooApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  //  [Authorize]
    public class LabelController : ControllerBase
    {
        public readonly ILabelManager labelsManager;
        public LabelController(ILabelManager labelsManager)
        {
            this.labelsManager = labelsManager;
        }
        [HttpPost]
        [Route("AddLabel")]
        public async Task<ActionResult> AddLabe(Label labels)
        {
            try
            {
                var result = await this.labelsManager.AddLabels(labels);
                if (result == 1)
                {
                    return this.Ok(new { Status = true, Message = "Adding Label Successful", data = labels });
                }
                return this.BadRequest(new { Status = false, Message = "Label empty" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }

        [HttpPut]
        [Route("EditLabels")]
        public ActionResult EditLabel(Label labels)
        {
            try
            {
                var result = this.labelsManager.EditLabel(labels);
                if (result != null)
                {
                    return this.Ok(new { Status = true, Message = "Edit Label Successful", data = labels });
                }
                return this.BadRequest(new { Status = false, Message = "Label found empty" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }

        [HttpPut]
        [Route("DeleteLabel")]
        public ActionResult DeleteLabels(int userid)
        {
            try
            {
                var result = this.labelsManager.DeleteLabels(userid);
                if (result != null)
                {
                    return this.Ok(new { Status = true, Message = "Deleted label" });
                }
                return this.BadRequest(new { Status = false, Message = "label not found" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("GetAllLabel")]
        public async Task<ActionResult> GetAllLabels(int userid)
        {
            try
            {
                var result = this.labelsManager.GetAllLabels(userid);
                if (result != null)
                {
                    return this.Ok(new { Status = true, Message = "labels displayed", data = result });
                }
                return this.BadRequest(new { Status = false, Message = "No labels Found" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("GetAllLabelNotes")]
        public async Task<ActionResult> GetAllLabelNotes(int userid)
        {
            try
            {
                var result = this.labelsManager.GetAllLabelNotes(userid);
                return this.Ok(new { Status = true, Message = "labels displayed", data = result });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }
    }
}
