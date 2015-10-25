using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Device
    {
        public int Id { get; private set; }
        public DateTime ExtaditionDate { get; private set; }
        public Measurements Measurements { get; private set; }

        public Device(int id, DateTime extraditionDate)
        {
            Id = id;
            ExtaditionDate = extraditionDate;
            Measurements = new Measurements();
        }
    }
}