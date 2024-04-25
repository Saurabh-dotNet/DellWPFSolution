using DellWPFSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DellWPFSolution.Actions
{
    class ProcessData : IProcessData
    {
        public TYPE Process(string s)
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
