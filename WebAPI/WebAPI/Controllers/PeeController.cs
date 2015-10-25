using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class PeeController : ApiController
    {
        static Patients _patients = new Patients();
        static Devices _devices = new Devices();

        [HttpGet, ActionName("patient")] // Get all patients
        public List<Patient> GetPatients()
        {
            return _patients.GetPatients();
        }

        [HttpGet, ActionName("patient")] // Get specific patient
        public Patient GetPatient(int id)
        {
            return _patients.GetPatients().Find(p => p.Id == id);
        }

        [HttpPut, ActionName("patient")] // Add patient
        public Patient AddPatient(string name, byte age)
        {
            return _patients.AddPatient(name, age);
        }

        [HttpDelete, ActionName("patient")] // Remove patient
        public bool RemovePatient(int id)
        {
            int i = _patients.GetPatients().FindIndex(p => p.Id == id);
            _patients.RemovePatient(i);
            return true;
        }

        [HttpPost, ActionName("patient")] // Assign device to patient
        public bool AssignDevice(int id, int dId)
        {
            if(_devices.GetDevices().Exists(d => d.Id == dId)) GetPatient(id).AssignDevice(dId);
            return true;
        }

        [HttpPost, ActionName("patient")] // Decouple device from patient
        public bool DecoupleDecive(int id)
        {
            if (GetPatient(id).Device > -1) GetPatient(id).AssignDevice(-1);
            return true;
        }

        [HttpGet, ActionName("device")] // Get all devices
        public List<Device> GetDevices()
        {
            return _devices.GetDevices();
        }

        [HttpGet, ActionName("device")] // Get specific device
        public Device GetDevice(int id)
        {
            var t = _devices.GetDevices().Find(d => d.Id == id);
            var g = t;
            return _devices.GetDevices().Find(d => d.Id == id);
        }

        [HttpDelete, ActionName("device")] // Remove device
        public bool RemoveDevice(int id)
        {
            _devices.RemoveDevice(id);
            return true;
        }

        [HttpPut, ActionName("measurement")] // Add measurement
        public bool AddMeasurement(int id, string values)
        {
            _devices.AddMeasurement(id, values);
            return true;
        }
    }
}
