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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGP
{
    public class Rider
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Number { get; set; }
        public string Team { get; set; }
        public bool FactoryTeam { get; set; }

        public Rider(string name, string surname, int number, string team, bool factory_team)
        {
            Name = name; 
            Surname = surname;
            Number = number; 
            Team = team;
            FactoryTeam = factory_team;
        }

        public void Edit(string e_name, string e_surname, int e_number, string e_team, bool e_factory_team)
        {
            this.Name = e_name;
            this.Surname = e_surname;
            this.Number = e_number;
            this.Team = e_team;
            this.FactoryTeam = e_factory_team;
        }

        public override string ToString()
        {
            return Name + " " + Surname + " " + " | " + " " + Number;
        }
    }
}
