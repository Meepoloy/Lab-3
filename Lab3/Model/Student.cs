using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Model
{
    public class Student
    {
        public string firstName
        {
            get;
            set;
        }

        public string lastName
        {
            get;
            set;
        }
        public string studId
        {
            get;
            set;
        }
        public string emailAdd
        {
            get;
            set;
        }
        public string password
        {
            get;
            set;
        }
        public string description
        {
            get;
            set;
        }

    }
}
