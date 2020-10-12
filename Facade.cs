using System;
using System.Collections.Generic;
using System.Linq;

namespace Clinic
{
    class Facade
    {
        private List<Patient> patients = new List<Patient>();
        private List<Doctor> doctors = new List<Doctor>();
        private List<Visit> visits = new List<Visit>();

        public List<Patient> Patients { get => patients; set => patients = value; }
        public List<Doctor> Doctors { get => doctors; set => doctors = value; }
        Database_controller Database = new Database_controller();

        public void updatedata()
        {

            patients = Database.Patients.ToList();
            doctors = Database.Doctors.ToList();
            visits = Database.Visits.ToList();

        }
        public string Add_patient(String[] patient_data)
        {
            Patient Patient = new Patient();

            Patient.Name = patient_data[0];
            Patient.Surname = patient_data[1];
            Patient.Pesel = patient_data[2];

            String if_is = addpacjent(Patient);
            if (!"Is".Equals(if_is))
            {

                Database.Patients.Add(Patient);
                Database.SaveChanges();
                return "Dodano pacjenta";
            }
            else
            { return "Ten pacjent już istnieje"; }
        }

        public List<Patient> Find_patient(string[] data)

        {
            List<Patient> list = new List<Patient>();
            Patient patient = new Patient();
            patient.Surname = data[1];
            patient.Pesel = data[0];
            int i = patients.IndexOf(patient);
            if (i != -1)
            {
                list.Add(patients[i]);
                return list;
            }
            return null;

        }

        public String addpacjent(Patient val)
        {
            bool if_is = patients.Contains(val);
            if (if_is == true)
            {
                return ("Is");
            }
            else
            {
                patients.Add(val);
                return null;
            }
        }

        public string remove_patient(String[] patient_data)
        {
            List<Patient> ListPatient = Find_patient(patient_data);
            Patient Patient = ListPatient[0];
            if (Patient.Scheduled_visits != null)
            {
                Database.Visits.RemoveRange(Patient.Scheduled_visits);
            }
            Database.Patients.Remove(Patient);
            Database.SaveChanges();
            return "Usunięto pacjenta";
        }

        public string remove_doctor(String[] doctor_data)
        {
            List<Doctor> ListDoctor = Find_doctor(doctor_data);
            Doctor Doctor = ListDoctor[0];
            if (Doctor.Scheduled_visits != null)
            {
                Database.Visits.RemoveRange(Doctor.Scheduled_visits);
            }
            Database.Doctors.Remove(Doctor);
            Database.SaveChanges();
            return "Usunięto lekarza";
        }


        public List<Patient> getpatients()
        {
            patients = Database.Patients.ToList();
            return patients;

        }

        public List<Doctor> getdoctors()
        {
            doctors = Database.Doctors.ToList();
            return doctors;

        }

        public List<string> getdoctorsString()
        {
            List<string> list = new List<string>();

            doctors = Database.Doctors.ToList();
            foreach (Doctor doctor in doctors)

            {

                list.Add(doctor.ToString2());

            }

            return list;

        }
        public string Add_doctor(String[] doctor_data)
        {
            Doctor Doctor = new Doctor();

            Doctor.Name = doctor_data[0];
            Doctor.Surname = doctor_data[1];
            Doctor.Specialization = doctor_data[2];


            String if_is = addlekarz(Doctor);
            if (!"Is".Equals(if_is))
            {
                Database.Doctors.Add(Doctor);
                Database.SaveChanges();
                return "Dodano lekarza";
            }
            else
            { return "Ten lekarz już istnieje"; }
        }
        public String addlekarz(Doctor val)
        {
            bool if_is = doctors.Contains(val);
            if (if_is == true)
            {
                return ("Is");
            }
            else
            {
                doctors.Add(val);
                return null;
            }
        }

        public List<Doctor> Find_doctor(string[] data)

        {

            List<Doctor> list = new List<Doctor>();
            Doctor doctor = new Doctor();
            doctor.Surname = data[0];
            doctor.Specialization = data[1];
            int i = doctors.IndexOf(doctor);
            if (i != -1)
            {
                list.Add(doctors[i]);
                return list;
            }
            return null;

        }
        public String Add_visit(String[] data1, String[] data2, DateTime date)

        {

            List<Patient> Patient = Find_patient(data1);
            List<Doctor> Doctor = Find_doctor(data2);
            Visit visit = new Visit();
            visit.patient = Patient[0];
            visit.doctor = Doctor[0];
            visit.date = date;

            String if_is = addvisit(visit);
            if (!"Is".Equals(if_is))
            {

                Database.Visits.Add(visit);
                Database.SaveChanges();
                return "Dodano wizytę";
            }
            else
            { return "Ta wizyta już istnieje"; }
        }

        public String addvisit(Visit val)
        {
            bool if_is = visits.Contains(val);
            if (if_is == true)
            {
                return ("Is");
            }
            else
            {
                visits.Add(val);

                return null;
            }
        }

        public List<Visit> Find_visit(string[] doctordata, DateTime date, string[] patientdata)

        {
            List<Patient> patient = Find_patient(patientdata);
            List<Doctor> doctor = Find_doctor(doctordata);
            List<Visit> list = new List<Visit>();
            Visit visit = new Visit();
            visit.patient = patient[0];
            visit.doctor = doctor[0];
            visit.date = date;

            int i = visits.IndexOf(visit);
            if (i != -1)
            {
                list.Add(visits[i]);
                return list;
            }
            return null;

        }

        public String Delete_visit(string[] doctordata, DateTime date, string[] patientdata)

        {
            List<Visit> list = Find_visit(doctordata, date, patientdata);
            Visit visit = list[0];
            //Database.Visits.Attach(visit);
            Database.Visits.Remove(visit);
            Database.SaveChanges();
            return "Usunięto wizytę";

        }
        public List<String[]> Download_scheduled_visits(String[] data, DateTime date)

        {
            Doctor doctor = Find_doctor(data)[0];

            return doctor.get_visit_day(date);




        }
        public List<String[]> Download_visits_of_day(String[] data, DateTime date)

        {
            Doctor doctor = Find_doctor(data)[0];

            return doctor.get_visit_day(date);

        }

        public List<String> Download_free_visits_of_day(String[] data, DateTime date)

        {
            Doctor doctor = Find_doctor(data)[0];

            return doctor.get_free_visit_day(date);




        }
    }



}






