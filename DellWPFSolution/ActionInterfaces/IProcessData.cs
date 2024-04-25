using DellWPFSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DellWPFSolution
{
    interface IProcessData
    {
        /// <summary>
        /// Get type information of string entered
        /// </summary>
        /// <param name="s">string for which type information is needed</param>
        /// <returns>TYPE whether string, int or special character</returns>
        TYPE GetType(string s);

        /// <summary>
        /// Get color assocaited with the type
        /// </summary>
        /// <param name="t">type fopr which color needs to be determined</param>
        /// <returns>SolidBrushColor based on type</returns>
        SolidColorBrush GetColorFromType(TYPE t);
    }
}
