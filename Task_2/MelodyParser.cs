namespace Task_2
{
    static class MelodyParser
    {
        public static Note[] ParseMelody(string melody)
        {
            const int dur = 300;
            int t = melody.Length;
            int i = 0;

            Note[] notes = new Note[t];

            foreach (char ch in melody)
            {
                //Console.WriteLine(ch);
                switch (ch)
                {
                    case '0': // до
                        notes[i] = Note.CreateNoteC(1, dur);
                        break;

                    case '1': // ре
                        notes[i] = Note.CreateNoteD(1, dur);
                        break;

                    case '2': // ми
                        notes[i] = Note.CreateNoteE(1, dur);
                        break;

                    case '3': // фа
                        notes[i] = Note.CreateNoteF(1, dur);
                        break;

                    case '4': // соль
                        notes[i] = Note.CreateNoteG(1, dur);
                        break;

                    case '5': // ля
                        notes[i] = Note.CreateNoteA(1, dur);
                        break;

                    case '6': // си
                        notes[i] = Note.CreateNoteB(1, dur);
                        break;

                    case '7': // до второй актавы
                        notes[i] = Note.CreateNoteC(2, dur);
                        break;

                    case '8': // ре второй актавы
                        notes[i] = Note.CreateNoteD(2, dur);
                        break;

                    case '9': // ми второй актавы
                        notes[i] = Note.CreateNoteE(2, dur);
                        break;

                    default: // пауза
                        notes[i] = Note.CreatePause(true, dur);
                        break;
                }
                i++;
            }

            return notes;
        }
    }
}
