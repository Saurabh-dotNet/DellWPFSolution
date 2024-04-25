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
        string CreateLabel1(DisplayModel model);
        string CreateLabel1Process(DisplayModel model);
        string CreateLabel2(DisplayModel model);
    }
}
