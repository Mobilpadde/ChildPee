using System;
using System.Collections.Generic;
using Database;

namespace WCF_Childpee
{
    public class Service1 : IService1
    {
        ChildpeeDatabase _database = new ChildpeeDatabase();
        public void RegDevice(int id, string extraditionDate)
        {
            _database.RegDevice(id, extraditionDate);
        }

        public List<Device> GetDevices()
        {
            return _database.GetDevices();
        }

        public List<Patient> GetPatients()
        {
           return _database.GetPatients();
        }

        public void RegPatients(int age, int deviceId, int id, string name, string deviceassigned)
        {
            _database.RegPatients(age, deviceId, id, name, deviceassigned);
        }

        public void RemoveDevice(int deviceId)
        {
            {
                _database.RemoveDevice(deviceId);
            }
        }

        public List<Measurement> GetmeasureList()
        {
            return _database.GetmeasureList();
        }

        public void AddinformationManually(string manuallyTime, int measurementId, bool value)
        {
            _database.AddinformationManually(manuallyTime, measurementId, value);
        }
    }
}
