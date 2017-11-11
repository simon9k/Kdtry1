using Kdtry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// change submit test
// line 2

namespace Kdtry.ViewModal
{
    public class PupilDayly
    {
        //4
        //5
        public ICollection<Pupil> Pupils { get; set; }
        public ICollection<Notice> Notices { get; set; }
        public ICollection<DaylySummary> DaylySummaries { get; set; }

    }
}
