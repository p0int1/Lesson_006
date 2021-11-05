using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Note
    {
        public int Hz { get; set; }
        public int Duration { get; set; }
        public bool IsPause { get; set; }

        // до - C / ре - D / ми - E / фа - F / соль - G / ля - A / си - B
        // https://nch-nch.ru/apps/frequency/
        // Статические фабричные методы.
        public static Note CreateNoteC(int oct, int dur) // до - C - 0
        {
            return new Note() { Hz = oct * 262, Duration = dur };
        }

        public static Note CreateNoteD(int oct, int dur) // ре - D - 1
        {
            return new Note() { Hz = oct * 293, Duration = dur };
        }

        public static Note CreateNoteE(int oct, int dur) // ми - E - 2
        {
            return new Note() { Hz = oct * 329, Duration = dur };
        }

        public static Note CreateNoteF(int oct, int dur) // фа - F - 3
        {
            return new Note() { Hz = oct * 349, Duration = dur };
        }

        public static Note CreateNoteG(int oct, int dur) // соль - G - 4
        {
            return new Note() { Hz = oct * 392, Duration = dur };
        }

        public static Note CreateNoteA(int oct, int dur) // ля - A - 5
        {
            return new Note() { Hz = oct * 440, Duration = dur };
        }

        public static Note CreateNoteB(int oct, int dur) // си - B - 6
        {
            return new Note() { Hz = oct * 493, Duration = dur };
        }

        public static Note CreatePause(bool pause, int dur) //пауза
        {
            return new Note() { Hz = 30000, Duration = dur, IsPause = pause };
        }
    }
}
