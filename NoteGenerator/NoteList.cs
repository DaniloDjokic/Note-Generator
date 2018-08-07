using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteGenerator
{
    static class NoteList
    {
        private static ListNode start;
        private static ListNode last;
        private static string[] notes = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

        static NoteList()
        {
            start = new ListNode("C");
            last = start;
            for (int i = 1; i < notes.Length; i++)
            {
                last.Next = new ListNode(notes[i]);
                last = last.Next;
            }
            last.Next = start;
        }

        public static string[] GetNoteSet(int value)
        {
            string[] temp = new string[12];
            int count = 0;
            ListNode point = start;
            switch(value)
            {
                case 6:
                    count = 4;
                    break;
                case 5:
                    count = 9;
                    break;
                case 4:
                    count = 2;
                    break;
                case 3:
                    count = 7;
                    break;
                case 2:
                    count = 11;
                    break;
                case 1:
                    count = 4;
                    break;
                default:
                    break;
            }
            while (count > 0)
            {
                point = point.Next;
                count--;
            }
            for (int i = 0; i < 12; i++)
            {
                temp[i] = point.Note;
                point = point.Next;
            }
            return temp;
        }
    }
}
