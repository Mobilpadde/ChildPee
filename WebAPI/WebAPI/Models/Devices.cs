using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    [Serializable]
    public class Devices
    {
        public List<Device> _devices;
        private int _id;

        public Devices()
        {
            _devices = new List<Device>();
            if (_devices.Count() > 0) _id = _devices.Last().Id + 1;
            else _id = 0;

            var d = DateTime.Now;
            for (var i = 0; i < 5; i++)
            {
                _devices.Add(new Device(_id++, d));
                d.AddDays(1);
            }
        }

        public List<Device> GetDevices()
        {
            return _devices;
        } 

        public void AddDevice()
        {
            _devices.Add(new Device(_id++, DateTime.Now));
        }

        public void RemoveDevice(int id)
        {
            int i = _devices.FindIndex(d => d.Id == id);
            _devices.RemoveAt(i);
        }

        public void AddMeasurement(int id, string value)
        {
            _devices.Find(d => d.Id == id).Measurements.AddMeasurement(value);
        }
    }
}