using System;
using System.Diagnostics;

namespace Composite
{
    public class BpmConsoleOutput : BpmComponent
    {
        private string _text;
        public BpmConsoleOutput(int id, string text) : base(id)
        {
            _text = text;
        }
        public override void Draw()
        {
            Debug.Print("Draw the control");
        }
        public override void Start()
        {
            Console.WriteLine(_text);
        }
    }
}
