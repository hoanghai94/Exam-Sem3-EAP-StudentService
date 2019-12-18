using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace StudentService.Models
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public string StudentId { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string Email { get; set; }
    }

    public interface IStudentRepository
    {
        List<Student> GetAllStudent();
    }
}