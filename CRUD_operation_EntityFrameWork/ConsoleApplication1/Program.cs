using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Context;
using ConsoleApplication1.Model;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //youtube video link:https: //www.youtube.com/watch?v=LMWh5GddcGM&pbjreload=10

            //Insert
            #region Insert Operation

            //Student student = new Student("Forman", "C151097", "Dhaka");
            //int rowAffected = SaveStudent(student);
            //if (rowAffected > 0)
            //{
            //    Console.WriteLine("Save Successfully\n");
            //}
            //else
            //{
            //    Console.WriteLine("Insertion Failed\n");
            //}

            #endregion


            //update connectingMood
            #region UpdateOperation ConnectingMood

            //UniversityContext context=new UniversityContext();
            //Student existingStudent = context.Students.Find(2);
            //if (existingStudent != null)
            //{
            //    existingStudent.Name = "Asif";
            //    existingStudent.RegNo = "C151094";
            //    existingStudent.Address = "Chittagong";

            //    int rowAffectedUpdate = context.SaveChanges();
            //    if (rowAffectedUpdate > 0)
            //    {

            //        Console.WriteLine("Update Successfully\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("update Failed\n");  
            //    }

            //}

            #endregion

            //update DisconnectingMood
            #region UpdateOperation DisConnectingMood


            Student existingStudent = GetStudentById("C151097");
            if (existingStudent != null)
            {
                existingStudent.Address = "Dhaka";
                int rowAffectedUpadateStudent = UpdateStudent(existingStudent);


                if (rowAffectedUpadateStudent > 0)
                {

                    Console.WriteLine("Update Successfully\n");
                }
                else
                {
                    Console.WriteLine("update Failed\n");
                }
            }



            #endregion

            //Delete
            DeleteStudent(2);

            Console.ReadKey();
        }

        public static int SaveStudent(Student student)
        {
            UniversityContext context = new UniversityContext();

            context.Students.Add(student);
            int rowAffected = context.SaveChanges();
            return rowAffected;
        }

        public static Student GetStudentById(string regNo)
        {
            UniversityContext context = new UniversityContext();
            Student existingStudent = context.Students.FirstOrDefault(c => c.RegNo == regNo);
            return existingStudent;
        }

        public static int UpdateStudent(Student student)
        {
            UniversityContext context = new UniversityContext();
            context.Students.Attach(student);
            context.Entry(student).State = EntityState.Modified;

            int rowAffected=context.SaveChanges();
            return rowAffected;
        }

        public static void DeleteStudent(int id)
        {
            UniversityContext context = new UniversityContext();
            Student student = context.Students.Find(id);
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
        }
    }
}
