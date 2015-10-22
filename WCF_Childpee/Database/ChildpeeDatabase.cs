using System;
using System.Collections.Generic;

namespace Database
{
    public class ChildpeeDatabase
    {
        //Device section

        public static List<Device> Devicelist = new List<Device>()
        {
            new Device {Id = 10001, ExtraditionDate = new DateTime(2014,4,12)},
            new Device {Id = 10002, ExtraditionDate = new DateTime(2005,5,15)},
            new Device {Id = 10003, ExtraditionDate = new DateTime(2012,9,14)},
            new Device {Id = 10004, ExtraditionDate = new DateTime(2007,11,11)},
            new Device {Id = 10005, ExtraditionDate = new DateTime(2015,5,15)},
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
            new Patient{Age = 11, DeviceId = Devicelist[0].Id, PatientId = 20001, Name = "Signe", Deviceassigned = "MK8 Peealarm"},
            new Patient{Age = 7, DeviceId = Devicelist[1].Id, PatientId = 20002, Name = "Morten", Deviceassigned = "MK7 Peealarm"},
            new Patient{Age = 8, DeviceId = Devicelist[2].Id, PatientId = 20003, Name = "Peter", Deviceassigned = "MK9 Peealarm"},
            new Patient{Age = 14, DeviceId = Devicelist[3].Id, PatientId = 20004, Name = "Line", Deviceassigned = "MK8 Peealarm"},
            new Patient{Age = 5, DeviceId = Devicelist[4].Id, PatientId = 20005, Name = "Maria", Deviceassigned = "MK9 Peealarm"}
        };

        public List<Patient> GetPatients()
        {
            return Patientlist;
        }

        public void RegPatients(int age, int deviceId, int id, string name, string deviceassigned)
        {
            Patientlist.Add(new Patient { Age = age, DeviceId = deviceId, PatientId = id, Name = name, Deviceassigned = deviceassigned});
           
        }
        public void RemoveDevice(int deviceId)
        {
            foreach (Patient pd in Patientlist)
            {
                if (pd.DeviceId == deviceId)
                {
                    pd.Deviceassigned = "Removed";
                }
            }
        }

        //Measurement Section
        private static string Manuallytime = "Not Available";
        public List<Measurement> Measurementlist = new List<Measurement>()
        {
            new Measurement{ManuallyTime = Manuallytime ,MeasurementId = 30001, Time = new DateTime(15,02,12,02,57,03), Value = true},
            new Measurement{ManuallyTime = Manuallytime, MeasurementId = 30002, Time = new DateTime(15,02,12,22,46,09), Value = true}  
        };

        public void AddinformationManually(string manuallyTime, int measurementId, bool value)
        {
            Measurementlist.Add(new Measurement{ManuallyTime = manuallyTime, MeasurementId = measurementId, Value = value});
        } 
        public List<Measurement> GetmeasureList()
        {
            return Measurementlist;
        } 

    }
}
