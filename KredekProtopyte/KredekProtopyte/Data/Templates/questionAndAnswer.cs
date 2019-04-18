namespace KredekProtopyte.Data.Templates
{
    public class QuestionAndAnswer
    {
        public QuestionAndAnswer(string answer, string question)
        {
            Answer = answer;
            Question = question;
        }

        public string Answer { get; set; }
        public string Question { get; set; }
    }
}