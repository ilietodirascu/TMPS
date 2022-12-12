using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhvPatterns.Editor
{
    public class CareTaker
    {
        private Stack<Memento> _mementos = new();
        private Stack<Memento> _forwardMementos = new();

        public CareTaker(TextEditor textEditor)
        {
            _mementos.Push(new Memento(textEditor.GetState()));
        }
        public void Save(string state)
        {
            if (_mementos.Peek().GetState().Equals(state)) return;
            _mementos.Push(new Memento(state));
        }
        public Memento Undo(string state)
        {
            //ctrl+z
            if(_mementos.Count > 1)
            {
                var memento = _mementos.Pop();
                _forwardMementos.Push(memento);
                return _mementos.Peek();
            }
            return _mementos.First();
        }
        public Memento ForwardUndo(string state)
        {
            //ctrl+y
            if (_forwardMementos.Count == 0)
            {
                return new Memento(state);
            }
            var memento = _forwardMementos.Pop();
            _mementos.Push(memento);
            return _mementos.Peek();
        }
    }
}
