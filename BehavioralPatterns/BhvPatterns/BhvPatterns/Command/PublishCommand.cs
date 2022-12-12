using BhvPatterns.Editor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhvPatterns.Command
{
    public class PublishCommand
    {
        private TextEditor _textEditor;
        public PublishCommand (TextEditor textEditor)
        {
            _textEditor = textEditor;
        }

        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("You have entered publishing mode.");
            _textEditor.SaveCurrentState();
        }
    }
}
