using System;
using System.Collections.Generic;

namespace Clinic
{
    class Patient
    {
        public long PatientId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pesel { get; set; }
        public virtual List<Visit> Scheduled_visits { get; set; }

        public Patient()

        {


        }

        public String toString()
        {

            String pom1 = "\nImie: " + this.Name + ", Nazwisko: " + this.Surname + ", Pesel: " + this.Pesel + "\n";
            return pom1;

        }
        /*
        public string add_visit(Visit Visit)
        {
            Scheduled_visits = new List<Visit>();
            this.Scheduled_visits.Add(Visit);

            return "";

        }


    */
        public override bool Equals(Object ob)
        {
            String Name = Surname;
            String Name2 = ((Patient)ob).Surname;
            String Pesel1 = Pesel;
            String Pesel2 = ((Patient)ob).Pesel;
            bool a = Name.Equals(Name2);

            if (Pesel2 != "0")
            {

                bool b = Pesel1.Equals(Pesel2);
                bool c = false;
                if (a && b == true)
                {
                    c = true;
                }
                return c;
            }


            else return a;
        }
    }
}
