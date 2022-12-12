using BhvPatterns.Editor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhvPatterns.Command
{
    public class ControlSCommand : ICommand
    {
        private TextEditor _textEditor;

        public ControlSCommand(TextEditor textEditor)
        {
            _textEditor = textEditor;
        }

        public void Execute()
        {
            _textEditor.SaveCurrentState();
        }
    }
}
