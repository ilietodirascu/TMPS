using BhvPatterns.Editor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhvPatterns.Editor
{
    class Context
    {
        private State _state = null;

        public Context(State state)
        {
            _state = state;
        }
        public void TransitionTo(State state)
        {
            _state = state;
            _state.SetContext(this);
        }
        public void Save(TextEditor textEditor)
        {
            _state.HandleSave(textEditor);
        }
    }
}
