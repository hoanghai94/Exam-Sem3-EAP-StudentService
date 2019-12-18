using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using StudentService.Models;

namespace StudentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentSevice" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentSevice.svc or StudentSevice.svc.cs at the Solution Explorer and start debugging.
    public class StudentSevice : IStudentService
    {
        static IStudentService repository = new StudentRepository();
        public List<Student> GetAllStudent()
        {
            return repository.GetAllStudent();
        } 
    }
}
