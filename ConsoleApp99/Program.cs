using System;
using System.IO;

namespace ConsoleApp99
{
    class Program
    {
        static void Main(string[] args)
        {
            int r1 = 1800, r2 = 2100;
            string nazwa = @"c:\tmp\lata_przestępne.txt";
            FileStream plik = new FileStream(nazwa, FileMode.Create, FileAccess.Write, FileShare.None);
            System.IO.StreamWriter zapis = new StreamWriter(plik);
            for (int i=r1; i<=r2; i++)
            {
                if (((i%4==0)&&(i%100!=0))||(i%400==0))
                {
                    
                    zapis.WriteLine(i);
                    
                }
            }
            zapis.Close();
            plik.Close();
        }
    }
}
