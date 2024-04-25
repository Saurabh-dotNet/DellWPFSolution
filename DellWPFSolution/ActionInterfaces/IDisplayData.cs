using DellWPFSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellWPFSolution.ActionInterfaces
{
    interface IDisplayData
    {
        /// <summary>
        /// Create 1st label from model data upon clicking Enter
        /// </summary>
        /// <param name="model">model object where data is stored</param>
        /// <returns>label 1 string</returns>
        string CreateLabel1(DisplayModel model);

        /// <summary>
        /// modify 1st label from model data upon clicking process
        /// </summary>
        /// <param name="model">model object where data is stored</param>
        /// <returns>label 1 string</returns>
        string CreateLabel1Process(DisplayModel model);

        /// <summary>
        /// Create 2nd label from model data upon clicking Process
        /// </summary>
        /// <param name="model">model object where data is stored</param>
        /// <returns>label 2 string</returns>
        string CreateLabel2(DisplayModel model);
    }
}
