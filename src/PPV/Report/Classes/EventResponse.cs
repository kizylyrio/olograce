using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report.Classes
{
    public class EventResponse
    {
        public EventClassification Status { get; set; }
        public string Description { get; set; }
    }

    public enum EventClassification
    {
        IDid = 3,
        NoHappen = 2,
        IDidNot = 1,
    }
}
