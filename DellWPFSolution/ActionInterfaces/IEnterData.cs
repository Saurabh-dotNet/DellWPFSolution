using DellWPFSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellWPFSolution.ActionInterfaces
{
    interface IEnterData
    {
        /// <summary>
        /// Add provided string to various variables of the model
        /// </summary>
        /// <param name="model">model object where variables to be altered</param>
        /// <param name="s">string data to be entered</param>
        void AddString(DisplayModel model,string s);
    }
}
