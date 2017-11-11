using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kdtry.Models
{
    public class Notice
    {
        public int NoticeID { set; get; }
        public int PupilID { set; get; }
        public string Message { set; get; }
        public virtual ICollection<Pupil> Pupil { set; get; }

    }
}