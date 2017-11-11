using System;
using System.Collections.Generic;

namespace Kdtry.Models
{
    public class Pupil
    {
        public int ID { get; set; }
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public virtual ICollection<DaylySummary> DaylySummaries { get; set; }
        public virtual ICollection<Notice> Notices { get; set; }
    }
}