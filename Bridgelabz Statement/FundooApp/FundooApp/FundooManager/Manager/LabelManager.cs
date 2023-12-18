using FundooManager.IManager;
using FundooModel.Labels;
using FundooRepo.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Manager
{
    public class LabelManager : ILabelManager
    {
        public readonly ILabelRepository LabelRepository;
        public LabelManager(ILabelRepository LabelRepository)
        {
            this.LabelRepository = LabelRepository;
        }
        public Task<int> AddLabels(Label labels)
        {
            var result = this.LabelRepository.AddLabels(labels);
            return result;
        }

        public bool DeleteLabels(int userid)
        {
            var result = this.LabelRepository.DeleteLabels(userid);
            return result;
        }

        public Label EditLabel(Label labels)
        {
            var result = this.LabelRepository.EditLabel(labels);
            return result;
        }

        public IEnumerable<Label> GetAllLabels(int userid)
        {
            var result = this.LabelRepository.GetAllLabels(userid);
            return result;
        }
        public IEnumerable<Label> GetAllLabelNotes(int userid)
        {
            var result = this.LabelRepository.GetAllLabelNotes(userid);
            return result;
        }
    }
}
