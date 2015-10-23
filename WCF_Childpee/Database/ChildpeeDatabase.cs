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
        public int RegDevice(DateTime extraditionDate)
        {
            var device = new Device();

            device.ExtraditionDate = extraditionDate;
            device.Id = Devicelist.Count + 1;

            Devicelist.Add(device);
            return device.Id;
        }

        public List<Device> GetDevices()
        {
            return Devicelist;
        }


        //Patients Section
        private static List<Patient> Patientlist = new List<Patient>()
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

        public int RegPatients(int age, int deviceId, string name, string deviceassigned)
        {
            //Patientlist.Add(new Patient { Age = age, DeviceId = deviceId, PatientId = id, Name = name, Deviceassigned = deviceassigned});

            var patient = new Patient();

            patient.DeviceId = deviceId;
            patient.Age = age;
            patient.Deviceassigned = deviceassigned;
            patient.Name = name;
            patient.PatientId = Patientlist.Count + 1;

            Patientlist.Add(patient);
            return patient.PatientId;
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

        private static string manuallytime = "Not Available";
        private List<Measurement> Measurementlist = new List<Measurement>()
        {
            new Measurement{ManuallyTime = manuallytime ,MeasurementId = 30001, Time = new DateTime(15,02,12,02,57,03), Value = true},
            new Measurement{ManuallyTime = manuallytime, MeasurementId = 30002, Time = new DateTime(15,02,12,22,46,09), Value = true}  
        };

        public void AddinformationManually(string manuallyTime, int measurementId, bool value)
        {
            Measurementlist.Add(new Measurement { ManuallyTime = manuallyTime, MeasurementId = measurementId, Time = DateTime.Parse(manuallyTime), Value = value });
        } 
        public List<Measurement> GetmeasureList()
        {
            return Measurementlist;
        } 

    }
}
