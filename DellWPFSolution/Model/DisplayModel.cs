using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellWPFSolution.Model
{
    class DisplayModel
    {
        public string Label1Text { get; set; }
        public string Label2Text { get; set; }
        public string TextBox1Text { get; set; }
        public Queue<string> TextBoxData { get; private set; }
        public Queue<string> UntouchedTextBoxData { get; private set; }
        public Stack<string> ReverseData { get; private set; }
        public Stack<string> UntouchedReverseData { get; private set; }
        public DisplayModel()
        {
            TextBoxData = new Queue<string>();
            UntouchedTextBoxData = new Queue<string>();
            ReverseData = new Stack<string>();
            UntouchedReverseData = new Stack<string>();
        }
    }

    enum TYPE
    {
        INT =1,
        STRING,
        SPECIAL,
        NONE,
        MIX,
    }
}
