using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Measurement
    {
        public int Id { get; private set; }
        public DateTime Time { get; private set; }
        public double Value { get; private set; }

        public Measurement(int id, DateTime time, double value)
        {
            Id = id;
            Time = time;
            Value = value;
        }
    }
}