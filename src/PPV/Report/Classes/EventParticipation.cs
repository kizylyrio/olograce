using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report.Classes
{
    public class EventParticipation
    {
        public EventClassification MensalMassService { get; set; }
        public EventClassification MensalChaplet { get; set; }
        public EventClassification FormalMeeting { get; set; }
        public EventClassification InformalMeeting { get; set; }
        public EventClassification EjnsEvent { get; set; }
    }
}
