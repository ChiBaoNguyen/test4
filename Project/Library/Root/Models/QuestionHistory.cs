using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root.Models
{
    public class QuestionHistory
    {
        // Foreign Key
        public int TestResultId { get; set; }
        // Foreign Key
        public int QuesCateType { get; set; }
        // Foreign Key
        public int QuesLevel { get; set; }
        public string Description { get; set; }
        public string Answers { get; set; }
        public int CorrectAnswer { get; set; }
        public string ApplicantAnswers { get; set; }
        public decimal Mark { get; set; }
    }
}
