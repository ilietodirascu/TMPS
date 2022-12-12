using BhvPatterns.Editor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhvPatterns.Command
{
    public class ControlZCommand : ICommand
    {
        private TextEditor _textEditor;

        public ControlZCommand(TextEditor textEditor)
        {
            _textEditor = textEditor;
        }

        public void Execute()
        {
            _textEditor.Restore();
        }
    }
}
