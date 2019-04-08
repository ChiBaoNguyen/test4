using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root.Models
{
    public class Question
    {
        // Key
        public int Id { get; set; }
        // Foreign Key
        public int QuesCateId { get; set; }
        // Foreign Key
        public int QuesLevelId { get; set; }
        public string Description { get; set; }
        public string Answers { get; set; }
        public int CorrectAnswer { get; set; }
        public decimal Mark { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
