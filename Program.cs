using System;
using TP_MODUL06_103022400071;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            SayaMusikTrack lagu = new SayaMusikTrack("Test Lagu");

            lagu.IncreasePlayCount(1000);
            lagu.PrintTrackDetails();

            lagu.IncreasePlayCount(20000000);

            for (int i = 0; i < 5; i++)
            {
                lagu.IncreasePlayCount(10000000);
            }

            lagu.PrintTrackDetails();
        }
        catch (Exception e)
        {
            Console.WriteLine("Terjadi error: " + e.Message);
            Console.ReadLine();
        }
    }
}