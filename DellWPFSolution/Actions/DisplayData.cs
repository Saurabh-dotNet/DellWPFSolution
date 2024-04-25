using DellWPFSolution.ActionInterfaces;
using DellWPFSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellWPFSolution.Actions
{
    class DisplayData : IDisplayData
    {
        public string CreateLabel1Process(DisplayModel model)
        {
            string s = string.Empty;
            foreach(string item in model.TextBoxData)
            {
                //string temp = model.ReverseData.Pop();
                s = item + s;
            }
            return s;
            //return string.Empty;
        }
        public string CreateLabel1(DisplayModel model)
        {
            string s = string.Empty;
            //var qEnum = q.GetEnumerator();
            foreach (string item in model.TextBoxData)
            {
                s = item + s;
                //model.ReverseData.Push(item);
                //model.UntouchedReverseData.Push(item);
            }
            //while (model.TextBoxData.Count > 0)
            //{
            //    string temp = model.TextBoxData.Dequeue();
            //    model.ReverseData.Push(temp);
            //    model.UntouchedReverseData.Push(temp);
            //    s = s + temp;
            //}
            return s;
        }

        public string CreateLabel2(DisplayModel model)
        {
            //string s = string.Empty;
            //while(model.ReverseData.Count > 0)
            //{
            //    string temp = model.ReverseData.Pop();
            //    s = s + temp;
            //}
            //model.ReverseData.Reverse();
            if (model.TextBoxData.Count > 0)
            {
                return model.TextBoxData.Dequeue();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
