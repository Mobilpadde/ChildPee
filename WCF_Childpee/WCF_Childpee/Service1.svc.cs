using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
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

        public void RegPatients(int age, int deviceId, int id, string name)
        {
            _database.RegPatients(age, deviceId,id,name);
        }

        public void RemoveDevice(int deviceId)
        {
            {
                _database.RemoveDevice(deviceId);
            }
        }

        public List<Measurement> GetmesureList()
        {
            return _database.GetmesureList();
        }

        public void AddinformationManually(string manuallyTime, int measurementId, bool value)
        {
            _database.AddinformationManually(manuallyTime, measurementId, value);
        }
    }
}
