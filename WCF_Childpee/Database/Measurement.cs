using System;

namespace Database
{
    public class Measurement
    {
        public DateTime Time { get; set; }
        public string ManuallyTime { get; set; }
        public bool Value { get; set; }
        public int MeasurementId { get; set; }
    }
}
