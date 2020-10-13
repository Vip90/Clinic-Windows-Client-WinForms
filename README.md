# Clinic-Windows-Client-WinForms
  Application Clinic is used to manage the reception work at the clinic : for adding patients, doctors and visits and managing them.
The idea for creating application comes from time when i used to going to allergy clinic and there wasnt any software to keeping records of visits so the lady at the reception desk had to write everything in a notebook. Unfortunately in those days I couldn't do programs so I leave it until 2020. I want create full system which will include WEB client in  ASP.NET Core, desktop client in WPF and maybe client for Android. 

This repository contains application using WinForms (.NET 4.7.2) with basic operations : adding and removing patients, doctors and visits. Database was created by Entity Framework in MS SQL. 

For run application first you need sql server, program is looking by default for sql instance SQLEXPRESS so you can change it by editing files App.config in main folder and Clinic 2020.exe.config in Clinic-Windows-Client-WinForms-master\bin\Debug. All you need to change, if you have windows authentication in sql, is "Server=.\SQLEXPRESS". Main exe is in 
Clinic-Windows-Client-WinForms-master\bin\Debug\Clinic 2020.exe


