using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL06_103022400071
{
    using System;

    public class SayaMusikTrack
    {
        private int id;
        private string PlayCount;
        private string title;

        public SayaMusikTrack(string title)
        {
            Random rand = new Random();
            this.id = rand.Next(10000, 100000);
            this.PlayCount = "0";
            this.title = title;
        }

        public void IncreasePlayCount(int count)
        {
            PlayCount += count;
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
