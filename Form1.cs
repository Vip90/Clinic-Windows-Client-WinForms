using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Clinic
{
    public partial class Form1 : Form
    {

        Facade facade = new Facade();

        public Form1()
        {
            InitializeComponent();
            facade.updatedata();


        }



        private void Add_patient_Click(object sender, EventArgs e)
        {
            facade.updatedata();
            string[] patient_data = { Patient_name.Text.ToString(), Patient_surname.Text.ToString(), Pesel.Text.ToString() };
            if (Patient_name.Text.Equals("") || Patient_surname.Text.Equals("") || Pesel.Text.Equals(""))
            {
                MessageBox.Show(this, "Prosze podać dane");
                return;
            }
            try
            {
                Int32.Parse(Pesel.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "W polu pesel wymagany jest format liczbowy");
                return;
            }
            string result = facade.Add_patient(patient_data);
            patients_table.DataSource = facade.getpatients();
            MessageBox.Show(result);
            Patient_name.Text = ""; Patient_surname.Text = ""; Pesel.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patients_table.DataSource = facade.getpatients();
            patients_table.Columns["PatientId"].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void list_content(List<string> col, ComboBox list)
        {

            list.Items.Clear();
            IEnumerable<String> iterator = col;

            foreach (string s in iterator)
            { list.Items.Add(s); }

        }

        private void change_columns_name(string a, DataGridView b)
        {
            if (a.Equals("D"))
            {
                b.Columns[1].HeaderText = "Imię";
                b.Columns[2].HeaderText = "Nazwisko";
                b.Columns[3].HeaderText = "Specjalizacja";

            }
            else
            {
                b.Columns[1].HeaderText = "Imię";
                b.Columns[2].HeaderText = "Nazwisko";
            }
        }

        private void goto_patients()
        {
            visits_panel.Visible = false;
            Start.Visible = false;
            doctors.Visible = false;
            Add_visit.Visible = false;
            Scheduled_visits.Visible = false;
            patients.Visible = true;
            patients_table.DataSource = facade.getpatients();
            change_columns_name("", patients_table);
            patients_table.Columns["PatientId"].Visible = false;

        }
        private void goto_doctors()
        {
            visits_panel.Visible = false;
            Start.Visible = false;
            patients.Visible = false;
            doctors.Visible = true;
            doctors_table.DataSource = facade.getdoctors();
            change_columns_name("D", doctors_table);
            doctors_table.Columns["DoctorId"].Visible = false;
        }


        private void goto_visits()
        {
            visits_panel.Visible = true;
            visit_start.Visible = true;
            Add_visit.Visible = false;
            Scheduled_visits.Visible = false;
            patients.Visible = false;
            doctors.Visible = false;
            Start.Visible = false;
            doctors.Visible = false;
            Add_visit.Visible = false;
            Scheduled_visits.Visible = false;
            patients.Visible = false;
            patients_table.DataSource = facade.getpatients();
            change_columns_name("", patients_table);
            patients_table.Columns["PatientId"].Visible = false;

        }

        private void goto_add_visit()
        {
            Start.Visible = false;
            visit_start.Visible = false;
            visits_panel.Visible = true;
            patients.Visible = false;
            doctors.Visible = false;
            Scheduled_visits.Visible = false;
            Add_visit.Visible = true;
            List_patients.DataSource = facade.getpatients();
            List_patients.Columns["PatientId"].Visible = false;
            change_columns_name("", List_patients);
            list_doctors.DataSource = facade.getdoctors();
            list_doctors.Columns["DoctorId"].Visible = false;
            change_columns_name("D", list_doctors);
        }

        private void goto_scheduled_visit()
        {
            Start.Visible = false;
            visit_start.Visible = false;
            visits_panel.Visible = true;
            patients.Visible = false;
            doctors.Visible = false;
            Add_visit.Visible = false;
            Scheduled_visits.Visible = true;
            List<string> list = facade.getdoctorsString();
            list_content(list, doctors_list);
            visits.DataSource = null;
        }
        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goto_patients();
        }

        private void main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_doctor(object sender, EventArgs e)
        {
            string[] doctor_data = { Tdoctor_name.Text.ToString(), Tdoctor_surname.Text.ToString(), Tdoctor_specialization.Text.ToString() };

            if (Tdoctor_name.Text.Equals("") || Tdoctor_surname.Text.Equals("") || Tdoctor_specialization.Text.Equals(""))

            {
                MessageBox.Show(this, "Prosze podać dane");
                return;
            }
            string result = facade.Add_doctor(doctor_data);
            doctors_table.DataSource = facade.getdoctors();

            MessageBox.Show(result);
            Tdoctor_name.Text = ""; Tdoctor_surname.Text = ""; Tdoctor_specialization.Text = "";
        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goto_doctors();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string[] data = { "0", find_patient.Text.ToString() };
            List_patients.DataSource = facade.Find_patient(data);
            if (find_patient.Text == "")
            { List_patients.DataSource = facade.getpatients(); }
            if (List_patients.DataSource != null)
            {
                change_columns_name("", List_patients);
            }
            if (List_patients.Columns.Count == 4)
            {
                List_patients.Columns["PatientId"].Visible = false;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string[] data = { find_doctor.Text.ToString(), "" };
            list_doctors.DataSource = facade.Find_doctor(data);
            if (find_doctor.Text == "")
            { list_doctors.DataSource = facade.getdoctors(); }
            if (list_doctors.DataSource != null)
            {
                change_columns_name("D", list_doctors);
            }
            if (list_doctors.Columns.Count == 4)
            {
                list_doctors.Columns["DoctorId"].Visible = false;
            }



        }

        private void add_visit_Click(object sender, EventArgs e)
        {

            if (List_patients.CurrentRow == null || list_doctors.CurrentRow == null)
            {

                MessageBox.Show("Wybierz pacjenta i lekarza");
            }

            else if (hours.SelectedItem == null)
            {
                MessageBox.Show("Brak wolnych terminów");

            }
            else
            {
                String[] patient_data = { List_patients.CurrentRow.Cells[3].Value.ToString(), List_patients.CurrentRow.Cells[2].Value.ToString() };
                String[] doctor_data = { list_doctors.CurrentRow.Cells[2].Value.ToString(), list_doctors.CurrentRow.Cells[3].Value.ToString() };
                String[] hour = hours.SelectedItem.ToString().Split(':');
                DateTime date = Calendar.SelectionRange.Start.AddHours(Convert.ToDouble(hour[0])).AddMinutes(Convert.ToDouble(hour[1]));

                string result = facade.Add_visit(patient_data, doctor_data, date);
                MessageBox.Show(result);
                hours.DataSource = facade.Download_free_visits_of_day(doctor_data, date);

            }

        }

        private void addVisitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            goto_add_visit();
        }

        private void scheduled_VisitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goto_scheduled_visit();
        }

        private void doctors_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (scheduled_visit.SelectionRange == null)
            {
                MessageBox.Show("Wybierz date");
            }
            else
            {
                string[] data = doctors_list.SelectedItem.ToString().Split(null);
                string[] data1 = { data[1], data[2] };
                DateTime date = scheduled_visit.SelectionRange.Start;
                refresh_visit_table(data1, date);
            }
        }

        private void refresh_visit_table(string[] data1, DateTime date)

        {
            List<String[]> object_ = facade.Download_visits_of_day(data1, date);
            if (object_ == null || object_.Count == 0)
            {
                MessageBox.Show("Brak rezerwacji w dniu " + date.ToShortDateString());
                visits.DataSource = null;
            }
            else
                visits.DataSource = object_.Select(arr => new { Pacjent = arr[0], Data = arr[1] }).ToArray();

        }
        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            hours.SelectedIndex = -1;
            if (List_patients.CurrentRow == null || list_doctors.CurrentRow == null)
            {

                MessageBox.Show("Wybierz najpierw pacjenta i lekarza");
            }
            else
            {
                String[] doctor_data = { list_doctors.CurrentRow.Cells[2].Value.ToString(), list_doctors.CurrentRow.Cells[3].Value.ToString() };
                DateTime date = Calendar.SelectionRange.Start;
                hours.DataSource = facade.Download_free_visits_of_day(doctor_data, date);
            }
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (doctors_list.SelectedItem == null)
            {
                MessageBox.Show("Wybierz lekarza");
            }
            else
            {
                string[] data = doctors_list.SelectedItem.ToString().Split(null);
                string[] data1 = { data[1], data[2] };
                DateTime date = scheduled_visit.SelectionRange.Start;

                refresh_visit_table(data1, date);
            }
        }

        private void calendar_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (doctors_list.Items.Equals(0))
            {

            }
            if (List_patients.CurrentRow == null && list_doctors.CurrentRow == null)
            {


            }

            else
            {
                String[] doctor_data = { list_doctors.CurrentRow.Cells[2].Value.ToString(), list_doctors.CurrentRow.Cells[3].Value.ToString() };
                DateTime date = Calendar.SelectionRange.Start;
                hours.DataSource = facade.Download_free_visits_of_day(doctor_data, date);
            }
        }

        private void Delete_visit_Click(object sender, EventArgs e)
        {
            if (visits.CurrentRow == null)
            {

                MessageBox.Show("Wybierz wizytę do usunięcia");
            }

            else
            {

                string[] doctordata = doctors_list.SelectedItem.ToString().Split(null);
                string[] doctordata1 = { doctordata[1], doctordata[2] };
                DateTime date = DateTime.Parse(visits.CurrentRow.Cells[1].Value.ToString());
                string[] patientdata = visits.CurrentRow.Cells[0].Value.ToString().Split(null);
                string[] patientdata1 = { "0", patientdata[1] };
                MessageBox.Show(facade.Delete_visit(doctordata1, date, patientdata1));
                List<String[]> object_ = facade.Download_visits_of_day(doctordata1, date);
                refresh_visit_table(doctordata1, date);











            }
        }

        private void goto_patients_Click(object sender, EventArgs e)
        {
            goto_patients();
        }

        private void goto_doctors_Click(object sender, EventArgs e)
        {
            goto_doctors();
        }

        private void goto_visits_b_Click(object sender, EventArgs e)
        {
            goto_visits();
        }

        private void scheduled_visits_button_Click(object sender, EventArgs e)
        {
            goto_scheduled_visit();
        }

        private void add_visits_button_Click(object sender, EventArgs e)
        {
            goto_add_visit();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visits_panel.Visible = false;
            Start.Visible = true;
            patients.Visible = false;
            doctors.Visible = false;

        }

        private void findPatient1_TextChanged(object sender, EventArgs e)
        {
            string[] data = { "0", findPatient1.Text.ToString() };
            patients_table.DataSource = facade.Find_patient(data);
            if (findPatient1.Text == "")
            { patients_table.DataSource = facade.getpatients(); }
            if (patients_table.DataSource != null)
            {
                change_columns_name("", patients_table);
            }
            if (patients_table.Columns.Count == 4)
            {
                patients_table.Columns["PatientId"].Visible = false;
            }

        }

        private void delete_patient_Click(object sender, EventArgs e)
        {

            if (patients_table.CurrentRow == null)
            {

                MessageBox.Show("Wybierz pacjenta do usunięcia");
            }
            else
            {

                String[] patient_data = { patients_table.CurrentRow.Cells[3].Value.ToString(), patients_table.CurrentRow.Cells[2].Value.ToString() };
                string result = facade.remove_patient(patient_data);
                MessageBox.Show(result);
                patients_table.DataSource = facade.getpatients();
            }
        }

        private void delete_doctor_Click(object sender, EventArgs e)
        {
            if (doctors_table.CurrentRow == null)
            {
                MessageBox.Show("Wybierz lekarza do usunięcia");
            }
            else
            {

                String[] doctor_data = { doctors_table.CurrentRow.Cells[2].Value.ToString(), doctors_table.CurrentRow.Cells[3].Value.ToString() };
                string result = facade.remove_doctor(doctor_data);
                MessageBox.Show(result);
                doctors_table.DataSource = facade.getdoctors();
            }
        }

        private void find_Doctor1_TextChanged_1(object sender, EventArgs e)
        {
            string[] data = { findDoctor1.Text.ToString(), "" };
            doctors_table.DataSource = facade.Find_doctor(data);
            if (findDoctor1.Text == "")
            { doctors_table.DataSource = facade.getdoctors(); }
            if (doctors_table.DataSource != null)
            {
                change_columns_name("D", doctors_table);
            }
            if (doctors_table.Columns.Count == 4)
            {
                doctors_table.Columns["DoctorId"].Visible = false;
            }
        }

    }
}


