using System;

namespace SleepApp.Models
{
    public class UserModel
    {
        public int id {get;set;}
        public string firstName {get;set;}
        public string lastName {get;set;}
        public int age {get;set;}
        public DateTime sleepingTime {get;set;}
        public string userName {get;set;}
        public string password { get; set; }

    }
}