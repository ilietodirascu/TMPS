using BhvPatterns.Editor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhvPatterns.Editor
{
    class PublishState : State
    {
        public override void HandleSave(TextEditor textEditor)
        {
            var path = Environment.CurrentDirectory;
            Console.WriteLine("Enter where you want to save the file: ");
            var newPath = Console.ReadLine();
            path = newPath.Length > 0 ? newPath : path;
            using (StreamWriter sw = File.CreateText(path + @"\document.txt"))
            {
                sw.Write(textEditor.GetState());
            }
        }
    }
}
