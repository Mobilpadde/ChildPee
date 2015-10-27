using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Measurements
    {
        private int _id;
        private List<Measurement> _measurements;

        public Measurements()
        {
            _id = 0;
            _measurements = new List<Measurement>();
        }

        public void AddMeasurement(string value)
        {
            string[] values = value.Split(',');
            List<double> dValues = new List<double>();
            values.ToList().ForEach(v =>
            {
                double q;
                double.TryParse(v, out q);
                dValues.Add(q);
            });
            
            dValues.ForEach(v => _measurements.Add(new Measurement(_id++, DateTime.Now, v)));
        }

        public List<Measurement> GetMeasurements()
        {
            return _measurements;
        } 
    }
}