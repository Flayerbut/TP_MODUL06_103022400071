using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL06_103022400071
{
    using System;
    using System.Diagnostics;

    public class SayaMusikTrack
    {
        private int id;
        private string PlayCount;
        private string title;

        public SayaMusikTrack(string title)
        {
            Debug.Assert(title != null, "Judul tidak boleh kosong");
            Debug.Assert(title.Length <= 100, "Judul maksimalnya adalah 100 karakter");

            Random rand = new Random();
            this.id = rand.Next(10000, 100000);
            this.title = title;
            this.PlayCount = "0";
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "Maksimal penambahan 10 juta");

            try
            {
                int current = int.Parse(PlayCount);

                checked
                {
                    current += count;
                }

                PlayCount = current.ToString();
            }
            catch (OverflowException)
            {
                Console.WriteLine("ERROR: Terjadi overflow!");
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
        public void PrintTrackDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + PlayCount);
            Console.WriteLine("----------------------");
        }
    }
}
