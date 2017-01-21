using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vahvistin
{
    public class Vahvari
    {
        int aanenVoimakkuus;

        public int getAanenVoimakkuus()
        {
        return aanenVoimakkuus;
        }

        public void setAanenVoimakkuus(int db)
        {
            aanenVoimakkuus = db;
            if (db < 1 || db > 100)
                aanenVoimakkuus = 0;
        }
     

    }
}
