namespace Clinic
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.patients_table = new System.Windows.Forms.DataGridView();
            this.patient_data = new System.Windows.Forms.Label();
            this.Add_patient = new System.Windows.Forms.Button();
            this.pesel_patient = new System.Windows.Forms.Label();
            this.Patient_name = new System.Windows.Forms.TextBox();
            this.surname_patient = new System.Windows.Forms.Label();
            this.Patient_surname = new System.Windows.Forms.TextBox();
            this.name_patient = new System.Windows.Forms.Label();
            this.Pesel = new System.Windows.Forms.TextBox();
            this.patients = new System.Windows.Forms.Panel();
            this.delete_patient = new System.Windows.Forms.Button();
            this.findPatient1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.doctors = new System.Windows.Forms.Panel();
            this.findDoctor1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delete_doctor = new System.Windows.Forms.Button();
            this.doctors_table = new System.Windows.Forms.DataGridView();
            this.Tdoctor_surname = new System.Windows.Forms.TextBox();
            this.Tdoctor_specialization = new System.Windows.Forms.TextBox();
            this.add_doctor_button = new System.Windows.Forms.Button();
            this.doctor_name = new System.Windows.Forms.Label();
            this.doctor_specialization = new System.Windows.Forms.Label();
            this.doctor_surname = new System.Windows.Forms.Label();
            this.Tdoctor_name = new System.Windows.Forms.TextBox();
            this.doctor_data = new System.Windows.Forms.Label();
            this.Add_visit = new System.Windows.Forms.Panel();
            this.hours = new System.Windows.Forms.ComboBox();
            this.add_visit_button = new System.Windows.Forms.Button();
            this.adding_visit = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.find_doctor = new System.Windows.Forms.TextBox();
            this.find_patient = new System.Windows.Forms.TextBox();
            this.findDoctor = new System.Windows.Forms.Label();
            this.findPatient = new System.Windows.Forms.Label();
            this.list_doctors = new System.Windows.Forms.DataGridView();
            this.List_patients = new System.Windows.Forms.DataGridView();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patients_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.doctors_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.visits_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.add_visit_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduled_visits_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Tittle = new System.Windows.Forms.Label();
            this.Scheduled_visits = new System.Windows.Forms.Panel();
            this.delete_visit = new System.Windows.Forms.Button();
            this.doctor = new System.Windows.Forms.Label();
            this.scheduled_visit = new System.Windows.Forms.MonthCalendar();
            this.doctors_list = new System.Windows.Forms.ComboBox();
            this.visits = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Panel();
            this.goto_visits_b = new System.Windows.Forms.Button();
            this.goto_patients_b = new System.Windows.Forms.Button();
            this.goto_doctors_b = new System.Windows.Forms.Button();
            this.visits_panel = new System.Windows.Forms.Panel();
            this.visit_start = new System.Windows.Forms.Panel();
            this.scheduled_visits_button = new System.Windows.Forms.Button();
            this.add_visits_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patients_table)).BeginInit();
            this.patients.SuspendLayout();
            this.doctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctors_table)).BeginInit();
            this.Add_visit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_doctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.List_patients)).BeginInit();
            this.Menu.SuspendLayout();
            this.Scheduled_visits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visits)).BeginInit();
            this.Start.SuspendLayout();
            this.visits_panel.SuspendLayout();
            this.visit_start.SuspendLayout();
            this.SuspendLayout();
            // 
            // patients_table
            // 
            this.patients_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patients_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.patients_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patients_table.Location = new System.Drawing.Point(342, 71);
            this.patients_table.Name = "patients_table";
            this.patients_table.Size = new System.Drawing.Size(375, 150);
            this.patients_table.TabIndex = 21;
            // 
            // patient_data
            // 
            this.patient_data.AutoSize = true;
            this.patient_data.Location = new System.Drawing.Point(25, 14);
            this.patient_data.Name = "patient_data";
            this.patient_data.Size = new System.Drawing.Size(105, 13);
            this.patient_data.TabIndex = 13;
            this.patient_data.Text = "Dodawanie pacjenta";
            // 
            // Add_patient
            // 
            this.Add_patient.Location = new System.Drawing.Point(28, 144);
            this.Add_patient.Name = "Add_patient";
            this.Add_patient.Size = new System.Drawing.Size(124, 23);
            this.Add_patient.TabIndex = 17;
            this.Add_patient.Text = "Dodaj pacjenta";
            this.Add_patient.UseVisualStyleBackColor = true;
            this.Add_patient.Click += new System.EventHandler(this.Add_patient_Click);
            // 
            // pesel_patient
            // 
            this.pesel_patient.AutoSize = true;
            this.pesel_patient.Location = new System.Drawing.Point(25, 103);
            this.pesel_patient.Name = "pesel_patient";
            this.pesel_patient.Size = new System.Drawing.Size(33, 13);
            this.pesel_patient.TabIndex = 20;
            this.pesel_patient.Text = "Pesel";
            // 
            // Patient_name
            // 
            this.Patient_name.Location = new System.Drawing.Point(84, 45);
            this.Patient_name.Name = "Patient_name";
            this.Patient_name.Size = new System.Drawing.Size(100, 20);
            this.Patient_name.TabIndex = 14;
            // 
            // surname_patient
            // 
            this.surname_patient.AutoSize = true;
            this.surname_patient.Location = new System.Drawing.Point(25, 74);
            this.surname_patient.Name = "surname_patient";
            this.surname_patient.Size = new System.Drawing.Size(53, 13);
            this.surname_patient.TabIndex = 19;
            this.surname_patient.Text = "Nazwisko";
            // 
            // Patient_surname
            // 
            this.Patient_surname.Location = new System.Drawing.Point(84, 71);
            this.Patient_surname.Name = "Patient_surname";
            this.Patient_surname.Size = new System.Drawing.Size(100, 20);
            this.Patient_surname.TabIndex = 15;
            // 
            // name_patient
            // 
            this.name_patient.AutoSize = true;
            this.name_patient.Location = new System.Drawing.Point(25, 45);
            this.name_patient.Name = "name_patient";
            this.name_patient.Size = new System.Drawing.Size(26, 13);
            this.name_patient.TabIndex = 18;
            this.name_patient.Text = "Imię";
            // 
            // Pesel
            // 
            this.Pesel.Location = new System.Drawing.Point(84, 100);
            this.Pesel.Name = "Pesel";
            this.Pesel.Size = new System.Drawing.Size(100, 20);
            this.Pesel.TabIndex = 16;
            // 
            // patients
            // 
            this.patients.Controls.Add(this.delete_patient);
            this.patients.Controls.Add(this.findPatient1);
            this.patients.Controls.Add(this.label1);
            this.patients.Controls.Add(this.patients_table);
            this.patients.Controls.Add(this.Patient_surname);
            this.patients.Controls.Add(this.patient_data);
            this.patients.Controls.Add(this.Pesel);
            this.patients.Controls.Add(this.Add_patient);
            this.patients.Controls.Add(this.name_patient);
            this.patients.Controls.Add(this.pesel_patient);
            this.patients.Controls.Add(this.surname_patient);
            this.patients.Controls.Add(this.Patient_name);
            this.patients.Location = new System.Drawing.Point(12, 76);
            this.patients.Name = "patients";
            this.patients.Size = new System.Drawing.Size(856, 344);
            this.patients.TabIndex = 23;
            this.patients.Visible = false;
            // 
            // delete_patient
            // 
            this.delete_patient.Location = new System.Drawing.Point(342, 245);
            this.delete_patient.Name = "delete_patient";
            this.delete_patient.Size = new System.Drawing.Size(124, 23);
            this.delete_patient.TabIndex = 29;
            this.delete_patient.Text = "Usuń pacjenta";
            this.delete_patient.UseVisualStyleBackColor = true;
            this.delete_patient.Click += new System.EventHandler(this.delete_patient_Click);
            // 
            // findPatient1
            // 
            this.findPatient1.Location = new System.Drawing.Point(342, 42);
            this.findPatient1.Name = "findPatient1";
            this.findPatient1.Size = new System.Drawing.Size(100, 20);
            this.findPatient1.TabIndex = 28;
            this.findPatient1.TextChanged += new System.EventHandler(this.findPatient1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Wyszukaj pacjenta po nazwisku";
            // 
            // doctors
            // 
            this.doctors.Controls.Add(this.findDoctor1);
            this.doctors.Controls.Add(this.label2);
            this.doctors.Controls.Add(this.delete_doctor);
            this.doctors.Controls.Add(this.doctors_table);
            this.doctors.Controls.Add(this.Tdoctor_surname);
            this.doctors.Controls.Add(this.Tdoctor_specialization);
            this.doctors.Controls.Add(this.add_doctor_button);
            this.doctors.Controls.Add(this.doctor_name);
            this.doctors.Controls.Add(this.doctor_specialization);
            this.doctors.Controls.Add(this.doctor_surname);
            this.doctors.Controls.Add(this.Tdoctor_name);
            this.doctors.Controls.Add(this.doctor_data);
            this.doctors.Location = new System.Drawing.Point(12, 76);
            this.doctors.Name = "doctors";
            this.doctors.Size = new System.Drawing.Size(865, 348);
            this.doctors.TabIndex = 26;
            this.doctors.Visible = false;
            // 
            // findDoctor1
            // 
            this.findDoctor1.Location = new System.Drawing.Point(264, 27);
            this.findDoctor1.Name = "findDoctor1";
            this.findDoctor1.Size = new System.Drawing.Size(100, 20);
            this.findDoctor1.TabIndex = 32;
            this.findDoctor1.TextChanged += new System.EventHandler(this.find_Doctor1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Wyszukaj lekarza po nazwisku";
            // 
            // delete_doctor
            // 
            this.delete_doctor.Location = new System.Drawing.Point(264, 227);
            this.delete_doctor.Name = "delete_doctor";
            this.delete_doctor.Size = new System.Drawing.Size(124, 23);
            this.delete_doctor.TabIndex = 30;
            this.delete_doctor.Text = "Usuń lekarza";
            this.delete_doctor.UseVisualStyleBackColor = true;
            this.delete_doctor.Click += new System.EventHandler(this.delete_doctor_Click);
            // 
            // doctors_table
            // 
            this.doctors_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctors_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.doctors_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctors_table.Location = new System.Drawing.Point(264, 60);
            this.doctors_table.Name = "doctors_table";
            this.doctors_table.Size = new System.Drawing.Size(347, 150);
            this.doctors_table.TabIndex = 28;
            // 
            // Tdoctor_surname
            // 
            this.Tdoctor_surname.Location = new System.Drawing.Point(98, 58);
            this.Tdoctor_surname.Name = "Tdoctor_surname";
            this.Tdoctor_surname.Size = new System.Drawing.Size(100, 20);
            this.Tdoctor_surname.TabIndex = 22;
            // 
            // Tdoctor_specialization
            // 
            this.Tdoctor_specialization.Location = new System.Drawing.Point(98, 84);
            this.Tdoctor_specialization.Name = "Tdoctor_specialization";
            this.Tdoctor_specialization.Size = new System.Drawing.Size(100, 20);
            this.Tdoctor_specialization.TabIndex = 23;
            // 
            // add_doctor_button
            // 
            this.add_doctor_button.Location = new System.Drawing.Point(8, 144);
            this.add_doctor_button.Name = "add_doctor_button";
            this.add_doctor_button.Size = new System.Drawing.Size(105, 23);
            this.add_doctor_button.TabIndex = 24;
            this.add_doctor_button.Text = "Dodaj lekarza";
            this.add_doctor_button.UseVisualStyleBackColor = true;
            this.add_doctor_button.Click += new System.EventHandler(this.add_doctor);
            // 
            // doctor_name
            // 
            this.doctor_name.AutoSize = true;
            this.doctor_name.Location = new System.Drawing.Point(5, 31);
            this.doctor_name.Name = "doctor_name";
            this.doctor_name.Size = new System.Drawing.Size(26, 13);
            this.doctor_name.TabIndex = 25;
            this.doctor_name.Text = "Imię";
            // 
            // doctor_specialization
            // 
            this.doctor_specialization.AutoSize = true;
            this.doctor_specialization.Location = new System.Drawing.Point(5, 89);
            this.doctor_specialization.Name = "doctor_specialization";
            this.doctor_specialization.Size = new System.Drawing.Size(69, 13);
            this.doctor_specialization.TabIndex = 27;
            this.doctor_specialization.Text = "Specjalizacja";
            // 
            // doctor_surname
            // 
            this.doctor_surname.AutoSize = true;
            this.doctor_surname.Location = new System.Drawing.Point(5, 60);
            this.doctor_surname.Name = "doctor_surname";
            this.doctor_surname.Size = new System.Drawing.Size(53, 13);
            this.doctor_surname.TabIndex = 26;
            this.doctor_surname.Text = "Nazwisko";
            // 
            // Tdoctor_name
            // 
            this.Tdoctor_name.Location = new System.Drawing.Point(98, 32);
            this.Tdoctor_name.Name = "Tdoctor_name";
            this.Tdoctor_name.Size = new System.Drawing.Size(100, 20);
            this.Tdoctor_name.TabIndex = 21;
            // 
            // doctor_data
            // 
            this.doctor_data.AutoSize = true;
            this.doctor_data.Location = new System.Drawing.Point(4, 11);
            this.doctor_data.Name = "doctor_data";
            this.doctor_data.Size = new System.Drawing.Size(70, 13);
            this.doctor_data.TabIndex = 14;
            this.doctor_data.Text = "Dane lekarza";
            // 
            // Add_visit
            // 
            this.Add_visit.BackColor = System.Drawing.Color.Silver;
            this.Add_visit.Controls.Add(this.hours);
            this.Add_visit.Controls.Add(this.add_visit_button);
            this.Add_visit.Controls.Add(this.adding_visit);
            this.Add_visit.Controls.Add(this.Calendar);
            this.Add_visit.Controls.Add(this.find_doctor);
            this.Add_visit.Controls.Add(this.find_patient);
            this.Add_visit.Controls.Add(this.findDoctor);
            this.Add_visit.Controls.Add(this.findPatient);
            this.Add_visit.Controls.Add(this.list_doctors);
            this.Add_visit.Controls.Add(this.List_patients);
            this.Add_visit.Location = new System.Drawing.Point(3, 11);
            this.Add_visit.Name = "Add_visit";
            this.Add_visit.Size = new System.Drawing.Size(868, 446);
            this.Add_visit.TabIndex = 23;
            this.Add_visit.Visible = false;
            this.Add_visit.Paint += new System.Windows.Forms.PaintEventHandler(this.main_Paint);
            // 
            // hours
            // 
            this.hours.FormattingEnabled = true;
            this.hours.Location = new System.Drawing.Point(630, 271);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(121, 21);
            this.hours.TabIndex = 32;
            // 
            // add_visit_button
            // 
            this.add_visit_button.Location = new System.Drawing.Point(619, 317);
            this.add_visit_button.Name = "add_visit_button";
            this.add_visit_button.Size = new System.Drawing.Size(132, 23);
            this.add_visit_button.TabIndex = 30;
            this.add_visit_button.Text = "Rezerwuj wizyte !";
            this.add_visit_button.UseVisualStyleBackColor = true;
            this.add_visit_button.Click += new System.EventHandler(this.add_visit_Click);
            // 
            // adding_visit
            // 
            this.adding_visit.AutoSize = true;
            this.adding_visit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adding_visit.Location = new System.Drawing.Point(290, 17);
            this.adding_visit.Name = "adding_visit";
            this.adding_visit.Size = new System.Drawing.Size(249, 31);
            this.adding_visit.TabIndex = 29;
            this.adding_visit.Text = "Dodawanie wizyty";
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(589, 89);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.ShowTodayCircle = false;
            this.Calendar.TabIndex = 28;
            this.Calendar.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Calendar.TrailingForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            this.Calendar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.calendar_MouseUp_1);
            // 
            // find_doctor
            // 
            this.find_doctor.Location = new System.Drawing.Point(297, 110);
            this.find_doctor.Name = "find_doctor";
            this.find_doctor.Size = new System.Drawing.Size(100, 20);
            this.find_doctor.TabIndex = 27;
            this.find_doctor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // find_patient
            // 
            this.find_patient.Location = new System.Drawing.Point(7, 110);
            this.find_patient.Name = "find_patient";
            this.find_patient.Size = new System.Drawing.Size(100, 20);
            this.find_patient.TabIndex = 26;
            this.find_patient.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // findDoctor
            // 
            this.findDoctor.AutoSize = true;
            this.findDoctor.Location = new System.Drawing.Point(293, 87);
            this.findDoctor.Name = "findDoctor";
            this.findDoctor.Size = new System.Drawing.Size(90, 13);
            this.findDoctor.TabIndex = 25;
            this.findDoctor.Text = "Wyszukaj lekarza";
            // 
            // findPatient
            // 
            this.findPatient.AutoSize = true;
            this.findPatient.Location = new System.Drawing.Point(5, 84);
            this.findPatient.Name = "findPatient";
            this.findPatient.Size = new System.Drawing.Size(97, 13);
            this.findPatient.TabIndex = 24;
            this.findPatient.Text = "Wyszukaj pacjenta";
            // 
            // list_doctors
            // 
            this.list_doctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.list_doctors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.list_doctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_doctors.Location = new System.Drawing.Point(297, 144);
            this.list_doctors.Name = "list_doctors";
            this.list_doctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_doctors.Size = new System.Drawing.Size(271, 81);
            this.list_doctors.TabIndex = 23;
            // 
            // List_patients
            // 
            this.List_patients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.List_patients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.List_patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_patients.Location = new System.Drawing.Point(8, 144);
            this.List_patients.Name = "List_patients";
            this.List_patients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.List_patients.Size = new System.Drawing.Size(271, 81);
            this.List_patients.TabIndex = 22;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1037, 24);
            this.Menu.TabIndex = 24;
            this.Menu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.patients_menu,
            this.doctors_menu,
            this.visits_menu});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // patients_menu
            // 
            this.patients_menu.Name = "patients_menu";
            this.patients_menu.Size = new System.Drawing.Size(118, 22);
            this.patients_menu.Text = "Pacjenci";
            this.patients_menu.Click += new System.EventHandler(this.patientsToolStripMenuItem_Click);
            // 
            // doctors_menu
            // 
            this.doctors_menu.Name = "doctors_menu";
            this.doctors_menu.Size = new System.Drawing.Size(118, 22);
            this.doctors_menu.Text = "Lekarze";
            this.doctors_menu.Click += new System.EventHandler(this.doctorsToolStripMenuItem_Click);
            // 
            // visits_menu
            // 
            this.visits_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_visit_menu,
            this.scheduled_visits_menu});
            this.visits_menu.Name = "visits_menu";
            this.visits_menu.Size = new System.Drawing.Size(118, 22);
            this.visits_menu.Text = "Wizyty";
            // 
            // add_visit_menu
            // 
            this.add_visit_menu.Name = "add_visit_menu";
            this.add_visit_menu.Size = new System.Drawing.Size(181, 22);
            this.add_visit_menu.Text = "Dodaj wizytę";
            this.add_visit_menu.Click += new System.EventHandler(this.addVisitToolStripMenuItem_Click);
            // 
            // scheduled_visits_menu
            // 
            this.scheduled_visits_menu.Name = "scheduled_visits_menu";
            this.scheduled_visits_menu.Size = new System.Drawing.Size(181, 22);
            this.scheduled_visits_menu.Text = "Zaplanowane wizyty";
            this.scheduled_visits_menu.Click += new System.EventHandler(this.scheduled_VisitsToolStripMenuItem_Click);
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tittle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Tittle.Location = new System.Drawing.Point(337, 24);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(335, 42);
            this.Tittle.TabIndex = 25;
            this.Tittle.Text = "Przychodnia 2020";
            // 
            // Scheduled_visits
            // 
            this.Scheduled_visits.Controls.Add(this.delete_visit);
            this.Scheduled_visits.Controls.Add(this.doctor);
            this.Scheduled_visits.Controls.Add(this.scheduled_visit);
            this.Scheduled_visits.Controls.Add(this.doctors_list);
            this.Scheduled_visits.Controls.Add(this.visits);
            this.Scheduled_visits.Controls.Add(this.label14);
            this.Scheduled_visits.Location = new System.Drawing.Point(0, 0);
            this.Scheduled_visits.Name = "Scheduled_visits";
            this.Scheduled_visits.Size = new System.Drawing.Size(892, 529);
            this.Scheduled_visits.TabIndex = 27;
            this.Scheduled_visits.Visible = false;
            // 
            // delete_visit
            // 
            this.delete_visit.Location = new System.Drawing.Point(20, 347);
            this.delete_visit.Name = "delete_visit";
            this.delete_visit.Size = new System.Drawing.Size(135, 23);
            this.delete_visit.TabIndex = 31;
            this.delete_visit.Text = "Usuń wybraną wizytę";
            this.delete_visit.UseVisualStyleBackColor = true;
            this.delete_visit.Click += new System.EventHandler(this.Delete_visit_Click);
            // 
            // doctor
            // 
            this.doctor.AutoSize = true;
            this.doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.doctor.Location = new System.Drawing.Point(26, 81);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(57, 20);
            this.doctor.TabIndex = 30;
            this.doctor.Text = "Lekarz";
            // 
            // scheduled_visit
            // 
            this.scheduled_visit.Location = new System.Drawing.Point(314, 67);
            this.scheduled_visit.MaxSelectionCount = 1;
            this.scheduled_visit.Name = "scheduled_visit";
            this.scheduled_visit.ShowTodayCircle = false;
            this.scheduled_visit.TabIndex = 29;
            this.scheduled_visit.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.scheduled_visit.TrailingForeColor = System.Drawing.Color.DeepSkyBlue;
            this.scheduled_visit.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // doctors_list
            // 
            this.doctors_list.FormattingEnabled = true;
            this.doctors_list.Location = new System.Drawing.Point(20, 112);
            this.doctors_list.Name = "doctors_list";
            this.doctors_list.Size = new System.Drawing.Size(170, 21);
            this.doctors_list.TabIndex = 25;
            this.doctors_list.SelectedIndexChanged += new System.EventHandler(this.doctors_list_SelectedIndexChanged);
            // 
            // visits
            // 
            this.visits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.visits.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.visits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visits.Location = new System.Drawing.Point(20, 194);
            this.visits.Name = "visits";
            this.visits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.visits.Size = new System.Drawing.Size(271, 81);
            this.visits.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(278, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(356, 42);
            this.label14.TabIndex = 0;
            this.label14.Text = "Zaplanowane wizyty";
            // 
            // Start
            // 
            this.Start.Controls.Add(this.goto_visits_b);
            this.Start.Controls.Add(this.goto_patients_b);
            this.Start.Controls.Add(this.goto_doctors_b);
            this.Start.Location = new System.Drawing.Point(0, 69);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(892, 446);
            this.Start.TabIndex = 33;
            // 
            // goto_visits_b
            // 
            this.goto_visits_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.goto_visits_b.Location = new System.Drawing.Point(631, 56);
            this.goto_visits_b.Name = "goto_visits_b";
            this.goto_visits_b.Size = new System.Drawing.Size(163, 61);
            this.goto_visits_b.TabIndex = 2;
            this.goto_visits_b.Text = "Wizyty";
            this.goto_visits_b.UseVisualStyleBackColor = true;
            this.goto_visits_b.Click += new System.EventHandler(this.goto_visits_b_Click);
            // 
            // goto_patients_b
            // 
            this.goto_patients_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.goto_patients_b.Location = new System.Drawing.Point(174, 56);
            this.goto_patients_b.Name = "goto_patients_b";
            this.goto_patients_b.Size = new System.Drawing.Size(163, 61);
            this.goto_patients_b.TabIndex = 1;
            this.goto_patients_b.Text = "Pacjenci";
            this.goto_patients_b.UseVisualStyleBackColor = true;
            this.goto_patients_b.Click += new System.EventHandler(this.goto_patients_Click);
            // 
            // goto_doctors_b
            // 
            this.goto_doctors_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.goto_doctors_b.Location = new System.Drawing.Point(401, 56);
            this.goto_doctors_b.Name = "goto_doctors_b";
            this.goto_doctors_b.Size = new System.Drawing.Size(163, 61);
            this.goto_doctors_b.TabIndex = 0;
            this.goto_doctors_b.Text = "Lekarze";
            this.goto_doctors_b.UseVisualStyleBackColor = true;
            this.goto_doctors_b.Click += new System.EventHandler(this.goto_doctors_Click);
            // 
            // visits_panel
            // 
            this.visits_panel.Controls.Add(this.Add_visit);
            this.visits_panel.Controls.Add(this.Scheduled_visits);
            this.visits_panel.Controls.Add(this.visit_start);
            this.visits_panel.Location = new System.Drawing.Point(0, 69);
            this.visits_panel.Name = "visits_panel";
            this.visits_panel.Size = new System.Drawing.Size(892, 381);
            this.visits_panel.TabIndex = 3;
            this.visits_panel.Visible = false;
            // 
            // visit_start
            // 
            this.visit_start.Controls.Add(this.scheduled_visits_button);
            this.visit_start.Controls.Add(this.add_visits_button);
            this.visit_start.Location = new System.Drawing.Point(0, 18);
            this.visit_start.Name = "visit_start";
            this.visit_start.Size = new System.Drawing.Size(880, 429);
            this.visit_start.TabIndex = 33;
            this.visit_start.Visible = false;
            // 
            // scheduled_visits_button
            // 
            this.scheduled_visits_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scheduled_visits_button.Location = new System.Drawing.Point(545, 119);
            this.scheduled_visits_button.Name = "scheduled_visits_button";
            this.scheduled_visits_button.Size = new System.Drawing.Size(227, 95);
            this.scheduled_visits_button.TabIndex = 1;
            this.scheduled_visits_button.Text = "Zaplanowane wizyty";
            this.scheduled_visits_button.UseVisualStyleBackColor = true;
            this.scheduled_visits_button.Click += new System.EventHandler(this.scheduled_visits_button_Click);
            // 
            // add_visits_button
            // 
            this.add_visits_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add_visits_button.Location = new System.Drawing.Point(184, 119);
            this.add_visits_button.Name = "add_visits_button";
            this.add_visits_button.Size = new System.Drawing.Size(227, 95);
            this.add_visits_button.TabIndex = 0;
            this.add_visits_button.Text = "Dodaj wizyte";
            this.add_visits_button.UseVisualStyleBackColor = true;
            this.add_visits_button.Click += new System.EventHandler(this.add_visits_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1037, 562);
            this.Controls.Add(this.visits_panel);
            this.Controls.Add(this.doctors);
            this.Controls.Add(this.patients);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Tittle);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Form1";
            this.Text = "Przychodnia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patients_table)).EndInit();
            this.patients.ResumeLayout(false);
            this.patients.PerformLayout();
            this.doctors.ResumeLayout(false);
            this.doctors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctors_table)).EndInit();
            this.Add_visit.ResumeLayout(false);
            this.Add_visit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_doctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.List_patients)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Scheduled_visits.ResumeLayout(false);
            this.Scheduled_visits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visits)).EndInit();
            this.Start.ResumeLayout(false);
            this.visits_panel.ResumeLayout(false);
            this.visit_start.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patients_table;
        private System.Windows.Forms.Label patient_data;
        private System.Windows.Forms.Button Add_patient;
        private System.Windows.Forms.Label pesel_patient;
        private System.Windows.Forms.TextBox Patient_name;
        private System.Windows.Forms.Label surname_patient;
        private System.Windows.Forms.TextBox Patient_surname;
        private System.Windows.Forms.Label name_patient;
        private System.Windows.Forms.TextBox Pesel;
        private System.Windows.Forms.Panel patients;
        private System.Windows.Forms.Panel Add_visit;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patients_menu;
        private System.Windows.Forms.ToolStripMenuItem doctors_menu;
        private System.Windows.Forms.ToolStripMenuItem visits_menu;
        private System.Windows.Forms.Label Tittle;
        private System.Windows.Forms.Panel doctors;
        private System.Windows.Forms.DataGridView doctors_table;
        private System.Windows.Forms.TextBox Tdoctor_surname;
        private System.Windows.Forms.TextBox Tdoctor_specialization;
        private System.Windows.Forms.Button add_doctor_button;
        private System.Windows.Forms.Label doctor_name;
        private System.Windows.Forms.Label doctor_specialization;
        private System.Windows.Forms.Label doctor_surname;
        private System.Windows.Forms.TextBox Tdoctor_name;
        private System.Windows.Forms.Label doctor_data;
        private System.Windows.Forms.DataGridView list_doctors;
        private System.Windows.Forms.DataGridView List_patients;
        private System.Windows.Forms.Label findDoctor;
        private System.Windows.Forms.Label findPatient;
        private System.Windows.Forms.TextBox find_patient;
        private System.Windows.Forms.TextBox find_doctor;
        private System.Windows.Forms.Label adding_visit;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Button add_visit_button;
        private System.Windows.Forms.ComboBox hours;
        private System.Windows.Forms.ToolStripMenuItem add_visit_menu;
        private System.Windows.Forms.Panel Scheduled_visits;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripMenuItem scheduled_visits_menu;
        private System.Windows.Forms.ComboBox doctors_list;
        private System.Windows.Forms.DataGridView visits;
        private System.Windows.Forms.MonthCalendar scheduled_visit;
        private System.Windows.Forms.Button delete_visit;
        private System.Windows.Forms.Label doctor;
        private System.Windows.Forms.Panel Start;
        private System.Windows.Forms.Button goto_visits_b;
        private System.Windows.Forms.Button goto_patients_b;
        private System.Windows.Forms.Button goto_doctors_b;
        private System.Windows.Forms.Panel visits_panel;
        private System.Windows.Forms.Panel visit_start;
        private System.Windows.Forms.Button scheduled_visits_button;
        private System.Windows.Forms.Button add_visits_button;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.Button delete_patient;
        private System.Windows.Forms.TextBox findPatient1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_doctor;
        private System.Windows.Forms.TextBox findDoctor1;
        private System.Windows.Forms.Label label2;
    }
}

