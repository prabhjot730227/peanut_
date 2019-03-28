using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c0730227
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Peter rules the IT Universe");
            Download();
            Console.ReadLine();
        }
        static void Download()
        {
            Task.Run(() =>
            {
                Thread.Sleep(7000);
                Console.WriteLine("Download complete");
            }
            );
           
            
            //
        }
    }
}
