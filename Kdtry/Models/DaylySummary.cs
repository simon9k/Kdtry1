using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kdtry.Models
{
    public class DaylySummary
    {
        public int DaylySummaryID { set; get; }
        public int PupilID { set; get; }
        public int Credits { set; get; }
        public string Summary { set; get; }
        public virtual ICollection<Pupil> Pupil {set;get;}

    }
}