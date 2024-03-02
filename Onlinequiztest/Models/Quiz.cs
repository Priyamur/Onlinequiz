namespace Onlinequiztest.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string? Title{ get; set; }
        public string? Category { get; set; }
      
        public int Numberofquestions { get; set; }

        public int Maximummark { get; set; }

        public int Totalmarks { get; set; }
    }
}
