using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;
using Repository.Models;


namespace Jotex.Models
{
    public class StudyViewModel
    {
        public IEnumerable<AgentPicture> AgentPictures { get; set; }

        public IEnumerable<Study> Studies { get; set; }

        public IEnumerable<StudySingle> StudySingles { get; set; }

        public IEnumerable<StudyDetail> StudyDetails { get; set; }
    }
}
