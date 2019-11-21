using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    public class StudentManagement
    {
        public PM13997[] GetStudents()
        {
            var db = new OOPCSEntities();
            return db.PM13997.ToArray();   
        }
        public void CreateStudent(string code, string name, string hometown, bool gender)
        {
            var newStudent = new PM13997();
            newStudent.Code = code;
            newStudent.Name = name;
            newStudent.Hometown = hometown;
            newStudent.Gender = gender;

            var db = new OOPCSEntities();
            db.PM13997.Add(newStudent);
            db.SaveChanges();
        }
        public void UpdateStudent(int id, string name, string hometown, string code, bool gender)
        {
            var db = new OOPCSEntities();
            var oldStudent = db.PM13997.Find(id);

            oldStudent.Name = name;
            oldStudent.Code = code;
            oldStudent.Gender = gender;
            oldStudent.Hometown = hometown;
            oldStudent.id = id;
            db.Entry(oldStudent).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteStudent(int id)
        {
            var db = new OOPCSEntities();
            var @student = db.PM13997.Find(id);
            db.PM13997.Remove(@student);
            db.SaveChanges();
            //db.Entry(@class).State = System.Data.Entity.EntityState.Modified;
        }
        public PM13997 GetStudent(int id)
        {
            var db = new OOPCSEntities();
            return db.PM13997.Find(id);
        }

    }
}
