using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class ChildpeeDatabase
    {
        //Device section

        public static List<Device> Devicelist = new List<Device>()
        {
            new Device {Id = 10001, ExtraditionDate = new DateTime(15,02,12)},
            new Device {Id = 10002, ExtraditionDate =  new DateTime(05,05,15)},
            new Device {Id = 10003, ExtraditionDate =  new DateTime(12,09,14)},
            new Device {Id = 10004, ExtraditionDate =  new DateTime(7,11,11)},
            new Device {Id = 10005, ExtraditionDate =  new DateTime(17,05,15)},
        };
        public void RegDevice(int id, string extraditionDate)
        {
            Devicelist.Add(new Device{Id = id, ExtraditionDate = DateTime.Parse(extraditionDate)});
        }

        public List<Device> GetDevices()
        {
            return Devicelist;
        }

        //Patients Section
        public static List<Patient> Patientlist = new List<Patient>()
        {
            new Patient{Age = 11, DeviceId = Devicelist[0].Id, Id = 20001, Name = "Signe"},
            new Patient{Age = 7, DeviceId = Devicelist[1].Id, Id = 20002, Name = "Morten"},
            new Patient{Age = 8, DeviceId = Devicelist[2].Id, Id = 20003, Name = "Peter"},
            new Patient{Age = 14, DeviceId = Devicelist[3].Id, Id = 20004, Name = "Line"},
            new Patient{Age = 5, DeviceId = Devicelist[4].Id, Id = 20005, Name = "Maria"}
        };

        public List<Patient> GetPatients()
        {
            return Patientlist;
        }

        public void RegPatients(int age, int deviceId, int id, string name)
        {
            Patientlist.Add(new Patient{Age = age, DeviceId = deviceId, Id = id, Name = name});
        }
        public void RemoveDevice(int deviceId)
        {
            foreach (Patient pd in Patientlist)
            {
                if (pd.DeviceId == deviceId)
                {
                    pd.Device = "Removed";
                }
            }
        }

        //Measurement Section

        public List<Measurement> Measurementlist = new List<Measurement>()
        {
            new Measurement{ManuallyTime = DateTime.Parse(""), MeasurementId = 30001, Time = new DateTime(15,02,12,02,57,03), Value = true},
            new Measurement{ManuallyTime = DateTime.Parse(""), MeasurementId = 30002, Time = new DateTime(15,02,12,22,46,09), Value = true}  
        };

        public void AddinformationManually(string manuallyTime, int measurementId, bool value)
        {
            Measurementlist.Add(new Measurement{ManuallyTime = DateTime.Parse(manuallyTime), MeasurementId = measurementId, Value = value});
        } 
        public List<Measurement> GetmesureList()
        {
            return Measurementlist;
        } 

    }
}
