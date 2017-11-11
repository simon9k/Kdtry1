using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Kdtry.Models;

namespace Kdtry.DAL
{
    public class KdtryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<KdtryContext>
    {
        protected override void Seed(KdtryContext context)
        {
            var Pupils = new List<Pupil>
            {
            new Pupil{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Pupil{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Pupil{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Pupil{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Pupil{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Pupil{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Pupil{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Pupil{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            Pupils.ForEach(s => context.Pupils.Add(s));
            context.SaveChanges();
            var DaylySummaries = new List<DaylySummary>
            {
            new DaylySummary{PupilID=1,Summary="Chemistry",Credits=3,},
            new DaylySummary{PupilID=4,Summary="Microeconomics",Credits=3,},
            new DaylySummary{PupilID=4,Summary="Macroeconomics",Credits=3,},
            new DaylySummary{PupilID=1,Summary="Calculus",Credits=4,},
            new DaylySummary{PupilID=3,Summary="Trigonometry",Credits=4,},
            new DaylySummary{PupilID=2,Summary="Composition",Credits=3,},
            new DaylySummary{PupilID=2,Summary="Literature",Credits=4,}
            };
            DaylySummaries.ForEach(s => context.DaylySummaries.Add(s));
            context.SaveChanges();

            var Notices = new List<Notice>
            {
            new Notice{PupilID=1,Message="Message.A"},
            new Notice{PupilID=4,Message="Message.C"},
            new Notice{PupilID=4,Message="Message.B"},
            new Notice{PupilID=1,Message="essage.B"},
            new Notice{PupilID=3,Message="essage.F"},
            new Notice{PupilID=2,Message="essage.F"},
            new Notice{PupilID=1},
            };
            Notices.ForEach(s => context.Notices.Add(s));
            context.SaveChanges();
        }
    }
}