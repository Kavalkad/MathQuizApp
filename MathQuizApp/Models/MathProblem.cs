namespace MathQuizApp.Models
{
    public class MathProblem
    {
        private int _num1;
        private int _num2;

        public int Num1
        {
            get { return _num1; }
            set { _num1 = value; }
        }
        public int Num2
        {
            get { return _num2; }
            set { _num2 = value; }
        }
        public string Operator { get; set; }
        public int CorrectAnswer => Calculate(Num1, Num2);

        public string UserAnswer { get; set; }
        public bool IsCorrect  => CorrectAnswer.ToString() == UserAnswer;
        public int Calculate(int num1, int num2)
        {
            return Operator == "+" ? num1 + num2 : num1 - num2;
        }

        public void Generate()
        {
            var rand = new Random();
            Num1 = rand.Next(0, 100);
            Num2 = rand.Next(0, 100);
            Operator = rand.Next(2) == 0 ? "+" : "-";
        }
    }
}
