using System;
using System.Collections.Generic;
using Database;

namespace WCF_Childpee
{
    public class Service1 : IService1
    {
        ChildpeeDatabase _database = new ChildpeeDatabase();
        public int RegDevice(DateTime extraditionDate)
        {
            return _database.RegDevice(extraditionDate);
        }

        public List<Device> GetDevices()
        {
            return _database.GetDevices();
        }

        public List<Patient> GetPatients()
        {
           return _database.GetPatients();
        }

        public int RegPatients(int age, int deviceId, string name, string deviceassigned)
        {
           return _database.RegPatients(age, deviceId,name, deviceassigned);
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
