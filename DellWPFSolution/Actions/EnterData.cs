using DellWPFSolution.ActionInterfaces;
using DellWPFSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellWPFSolution.Actions
{
    class EnterData : IEnterData
    {
        /// <summary>
        /// Add provided string to various variables of the model
        /// </summary>
        /// <param name="model">model object where variables to be altered</param>
        /// <param name="s">string data to be entered</param>
        void IEnterData.AddString(DisplayModel model, string s)
        {
            string text = s;
            if (!string.IsNullOrEmpty(text))
            {
                model.TextBoxData.Enqueue(text);
                model.UntouchedTextBoxData.Enqueue(text);
                model.ReverseData.Push(text);
                model.UntouchedReverseData.Push(text);
            }
        }
    }
}
