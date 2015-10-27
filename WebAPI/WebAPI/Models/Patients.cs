using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Patients
    {
        public List<Patient> _patients;
        private int _id;

        public Patients()
        {
            _patients = new List<Patient>();
            if (_patients.Count() > 0) _id = _patients.Last().Id + 1;
            else _id = 0;

            string[] names = { "Lise", "Bob", "Børge", "Søren", "Lotte" };
            Random rnd = new Random();

            foreach (string name in names)
            {
                _patients.Add(new Patient(_id++, name, byte.Parse(rnd.Next(6, 15).ToString())));
            }
        }

        public void AssignDevice(int id, int _deviceId)
        {
            _patients.Find(p => p.Id == id).AssignDevice(_deviceId);
        }

        public List<Patient> GetPatients()
        {
            return _patients;
        } 

        public Patient AddPatient(string name, byte age)
        {
            Patient p = new Patient(_id++, name, age);
            _patients.Add(p);
            return p;
        }

        public void RemovePatient(int id)
        {
            int i = _patients.FindIndex(p => p.Id == id);
            _patients.RemoveAt(i);
        }
    }
}