using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root.Models
{
   public class TestResult
    {
        // Key
        public int Id { get; set; }
        // Foreign Key
        public int AplicanlId { get; set; }
        // Foreign Key
        public int TestId { get; set; }
        public DateTime TestDate { get; set; }
        public string Duration { get; set; }
        public decimal Mark { get; set; }
        public int Result { get; set; }
        public string Status { get; set; }
        public string TestName { get; set; }
        public decimal PassingScore { get; set; }
        public string TestDuration { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
