using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentService.Models;

namespace StudentService
{
    public class StudentRepository : IStudentService
    {
        private readonly MyDbContext _db = new MyDbContext();
        public List<Student> GetAllStudent()
        {
            return _db.Students.ToList();
        }
    }
}