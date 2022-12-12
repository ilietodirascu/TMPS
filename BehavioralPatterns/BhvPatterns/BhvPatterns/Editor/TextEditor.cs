using BhvPatterns.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhvPatterns.Editor
{
    public class TextEditor
    {
        private string _state;
        private Context _context = new(new EditState());
        public readonly CareTaker _careTaker;
        private readonly ControlSCommand _save;
        private readonly ControlYCommand _undoForward;
        private readonly ControlZCommand _undo;
        private readonly PublishCommand _publish;
        public TextEditor(string state)
        {
            _state = state;
            _careTaker = new CareTaker(this);
            _save = new(this);
            _undoForward = new(this);
            _undo = new(this);
            _publish = new(this);
            Edit();
        }
        public void SaveCurrentState()
        {
            _careTaker.Save(_state);
            _context.Save(this);
        }
        public void PrintState()
        {
            Console.Write(_state);
        }
        public void SetState(string state)
        {
            _state = state;
            OnStateChange();
        }
        public void Restore()
        {
            SetState(_careTaker.Undo(_state).GetState());
        }
        public void RestoreForward()
        {
            SetState(_careTaker.ForwardUndo(_state).GetState());
        }
        public string GetState()
        {
            return _state;
        }
        public void OnStateChange()
        {
            Console.Clear();
            PrintState();
        }
        public void Edit()
        {
            ConsoleKeyInfo cki;
            // Prevent example from ending if CTL+C is pressed.
            Console.TreatControlCAsInput = true;
            do
            {
                cki = Console.ReadKey();
                if ((cki.KeyChar >= 48 && cki.KeyChar <= 57) || (cki.KeyChar >= 65 && cki.KeyChar <= 90))
                {
                    SetState(_state + cki.KeyChar);
                }
                else
                {
                    SetState(_state);
                }
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0 && cki.Key.ToString().Equals("Z")) _undo.Execute();
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0 && cki.Key.ToString().Equals("S")) _save.Execute();
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0 && cki.Key.ToString().Equals("Y")) _undoForward.Execute();
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0 && cki.Key.ToString().Equals("P")) { _context.TransitionTo(new PublishState()); break; }
            } while (cki.Key != ConsoleKey.Escape);
            Console.TreatControlCAsInput = false;
            _publish.Execute();
        }
    }
}
