using BhvPatterns.Editor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhvPatterns.Editor
{
    class EditState : State
    {
        public override void HandleSave(TextEditor textEditor)
        {
            textEditor._careTaker.Save(textEditor.GetState());
        }
    }
}
