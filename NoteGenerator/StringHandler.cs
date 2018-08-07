using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteGenerator
{
    class StringHandler
    {
        private Dictionary<int, string> noteValues = new Dictionary<int, string>();

        public StringHandler(int startingValue)
        {
            string[] temp = NoteList.GetNoteSet(startingValue);
            for (int i = 0; i < temp.Length; i++)
            {
                noteValues.Add(i, temp[i]);
            }
        }

        public KeyValuePair<int, string> GetPair()
        {
            string result = " ";
            Random r = new Random();
            int key = r.Next(1, 12);
            if (noteValues.TryGetValue(key, out result))
            {
                return new KeyValuePair<int, string>(key, result);
            }
            else throw new Exception("Nema te note");
        }
    }
}
