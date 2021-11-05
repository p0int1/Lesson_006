using System;

namespace Task_2
{
    static class Player
    {
        public static void Play(Note[] notes)
        {
            foreach (Note note in notes)
            {
                Console.WriteLine("частота: " + note.Hz);
                Console.Beep(note.Hz, note.Duration);
            }
        }
    }
}
