
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePendu
    {
        public class Word
        {
            public string Text { get; set; }
            public int Length { get; }

            public Word(string text)
            {
                Text = text.ToUpper();
                Length = Text.Length;
            }

            public int GetIndexOf(char letter)
            {
                return Text.IndexOf(letter);
            }
        }
    }

