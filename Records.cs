/***************************************************/
/***************************************************/
/***************************************************/
/***************************************************/
/*********  BOSON-HIGGS | neutron.surge.sh  ********/
/***************************************************/
/***************************************************/
/***************************************************/
/***************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGP
{
    public class Records
    {
        public BindingList<Rider> Riders { get; set; }

        public Records()
        {
            Riders = new BindingList<Rider>();
        }

        public void Add(string name, string surname, int number, string team, bool factory_team)
        {
            if(number < 1 && number > 99)
            {
                throw new ArgumentException("Rules define numbers in range 1 to 99");
            }
            Rider rider = new Rider(name, surname, number, team, factory_team);
            Riders.Add(rider);
        }

        public void Remove(Rider rider)
        {
            Riders.Remove(rider);
        }
    }
}
