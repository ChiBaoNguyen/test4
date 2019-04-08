using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root.Models
{
    public class Applicant
    {
        // Key
        public int Id { get; set; }
        // Foreign Key
        public int UserId { get; set; }
        // Foreign Key
        public int JobTitleId { get; set; }
        public DateTime ApplyDate { get; set; }
        public DateTime TestDate { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
