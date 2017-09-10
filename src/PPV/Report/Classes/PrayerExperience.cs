using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report.Classes
{
    public class PrayerExperience
    {
        public MemberResponse  IndividualPrayer { get; set; }
        public MemberResponse TimeoutAndMagnificat { get; set; }
        public MemberResponse BibleMeditation { get; set; }
        public MemberResponse ChapletPrayer { get; set; }
        public MemberResponse MassService { get; set; }
    }
}
