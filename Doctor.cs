﻿using System;
using System.Collections.Generic;

namespace Clinic
{
    class Doctor
    {
        public long DoctorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Specialization { get; set; }

        public virtual List<Visit> Scheduled_visits { get; set; }


        public string ToString2()
        {
            String pom1 = "" + this.Name + " " + this.Surname + " " + this.Specialization;
            return pom1;
        }

        public override bool Equals(Object ob)
        {
            String Name = Surname;
            String Name2 = ((Doctor)ob).Surname;
            string Specialization1 = Specialization;
            string Specialization2 = ((Doctor)ob).Specialization;
            bool a = Name.Equals(Name2);
            if (Specialization2 != "")
            {

                bool b = Specialization1.Equals(Specialization2);
                bool c = false;
                if (a && b == true)
                {
                    c = true;
                }
                return c;
            }

            else return a;
        }

        public List<String[]> get_visit_day(DateTime data)

        {
            List<String[]> list = new List<String[]>();

            if (Scheduled_visits == null)
                return null;

            else
                foreach (Visit next in Scheduled_visits)
                {
                    if (next.date.DayOfYear.Equals(data.DayOfYear))
                    {
                        String[] visit = new String[2];
                        visit[0] = next.patient.Name.ToString() + " " + next.patient.Surname.ToString();
                        visit[1] = next.date.ToString();
                        list.Add(visit);
                    }
                }
            return list;
        }



        public List<String> get_free_visit_day(DateTime data)

        {
            List<String> list = new List<String>();
            List<String> hours = new List<String>();
            DateTime hour = new DateTime();
            hour = hour.AddHours(9).AddMinutes(00);
            if (Scheduled_visits == null)
            {
                for (int j = 0; j <= 16; j++)
                {
                    hours.Add(hour.ToShortTimeString());
                    hour = hour.AddMinutes(30);
                }

                return hours;
            }



            else
                foreach (Visit next in Scheduled_visits)
                {
                    if (next.date.DayOfYear.Equals(data.DayOfYear))
                    {
                        String visit = "";
                        visit = next.patient.toString() + next.date.ToString();
                        list.Add(visit);
                    }
                }
            for (int j = 0; j <= 16; j++)

            {
                String result = "";
                String selected_time;

                int n = 0;
                do
                {
                    for (int i = 0; i < list.Count; i++)

                    {

                        if (list[i].Contains(hour.TimeOfDay.ToString()))
                        {
                            result = "Is";
                        }
                        n++;
                    }
                } while (n < list.Count);


                if (result != "Is")
                {
                    selected_time = hour.ToShortTimeString();

                    hours.Add(selected_time);
                }
                hour = hour.AddMinutes(30);
            }
            return hours;
        }
        public String visitsString()

        {

            String visit = "";
            foreach (Visit next in Scheduled_visits)
            {
                visit = next.patient.Name + next.patient.Surname;
            }
            return visit;
        }

    }
}







