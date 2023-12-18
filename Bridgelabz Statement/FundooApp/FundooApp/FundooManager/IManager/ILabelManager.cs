using FundooModel.Labels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.IManager
{
    public interface ILabelManager
    {
        public Task<int> AddLabels(Label labels);
        public Label EditLabel(Label labels);
        public IEnumerable<Label> GetAllLabels(int userid);
        public bool DeleteLabels(int userid);
        public IEnumerable<Label> GetAllLabelNotes(int userid);
    }
}
