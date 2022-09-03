using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Model
{
    class ToDoModel
    {
        public DateTime CreationTime { get; set; } = DateTime.Now;

        private bool isDone;
        private string text;

        public bool IsDone
        {
            get { return isDone; }
            set { isDone = value; }
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

    }
}
