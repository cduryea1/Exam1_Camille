//MIS 3033 Exam 1
//Camille Duryea
//113529005

using Exam1_CamilleDuryea.Data;

Console.WriteLine("Exam Code Here");
//get this during exam

Exam1DBContext db;
db = new Exam1DBContext();

var r = db.Orders.FirstOrDefault();
Console.WriteLine(r.Id);