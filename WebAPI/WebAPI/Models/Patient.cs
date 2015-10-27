using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    [Serializable]
    public class Patient
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public byte Age { get; private set; }
        public int Device { get; private set; }

        public Patient(int id, string name, byte age)
        {
            Id = id;
            Name = name;
            Age = age;
            Device = -1;
        }

        public Patient(int id, string name, byte age, int device)
        {
            Id = id;
            Name = name;
            Age = age;
            Device = device;
        }

        public void AssignDevice(int device)
        {
            Device = device;
        }
    }
}