using System;

namespace Clinic
{
    class Visit
    {
        public long VisitId { get; set; }
        public long PatientId { get; set; }
        public Patient patient { get; set; }
        public long DoctorId { get; set; }
        public Doctor doctor { get; set; }
        public DateTime date { get; set; }

        public Visit()

        {


        }

        public override bool Equals(Object ob)
        {

            Patient patient = this.patient;
            Patient patient2 = ((Visit)ob).patient;
            Doctor doctor = this.doctor;
            Doctor doctor2 = ((Visit)ob).doctor;
            DateTime date = this.date;
            DateTime date2 = ((Visit)ob).date;

            bool a = patient == (patient2);
            bool b = doctor == (doctor2);
            bool c = date.Equals(date2);
            bool d = false;

            if (a && b && c == true)
            {
                d = true;
            }


            return d;
        }

    }
}

