using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteGenerator
{
    class ListNode
    {
        private string note;
        public string Note { get { return note; } set { note = value; } }
        private ListNode next;
        public ListNode Next { get; set; }

        public ListNode(string value)
        {
            note = value;
            next = null;
        }
    }
}
