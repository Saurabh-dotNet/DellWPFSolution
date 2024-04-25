using DellWPFSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DellWPFSolution.Actions
{
    class ProcessData : IProcessData
    {
        /// <summary>
        /// Get color assocaited with the type
        /// </summary>
        /// <param name="t">type fopr which color needs to be determined</param>
        /// <returns>TYPE whether string, int or special character</returns>
        public SolidColorBrush GetColorFromType(TYPE t)
        {
            switch (t)
            {
                case (TYPE.STRING):
                    return new SolidColorBrush(Color.FromRgb(0, 255, 0));
                    break;
                case (TYPE.INT):
                    return new SolidColorBrush(Color.FromRgb(0, 0, 255));
                    break;
                case (TYPE.SPECIAL):
                    return new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    break;
                default:
                    return new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }

        /// <summary>
        /// Get type information of string entered
        /// </summary>
        /// <param name="s">string for which type information is needed</param>
        /// <returns>SolidBrushColor based on type</returns>
        public TYPE GetType(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return TYPE.NONE;
            }

            string charPattern = @"^[a-zA-Z]+$";
            string numPattern = @"^\d+$";
            string specialCharPattern = @"^[^\w\s]+$";

            if (Regex.IsMatch(s, charPattern))
            {
                return TYPE.STRING;
            }
            else if (Regex.IsMatch(s, numPattern))
            {
                return TYPE.INT;
            }
            else if (Regex.IsMatch(s, specialCharPattern))
            {
                return TYPE.SPECIAL;
            }
            else
            {
                return TYPE.MIX;
            }
        }

    }
}
