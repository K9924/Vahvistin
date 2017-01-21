using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vahvistin
{
    class Program
    {
        static void Main(string[] args)
        {
            Vahvari vahvistin = new Vahvari();
            int db = 0;

            
            Console.WriteLine("Annan äänenvoimmakkuus: ");
            db = int.Parse(Console.ReadLine());

            vahvistin.setAanenVoimakkuus(db);
            Console.WriteLine("Äänenvoimakkuus: " + vahvistin.getAanenVoimakkuus());

            
            Console.Read();
        }
    }
}
