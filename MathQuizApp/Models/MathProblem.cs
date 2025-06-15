namespace MathQuizApp.Models
{
    public class MathProblem
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public char Operator { get; set; }
        public int CorrectAnswer => Calculate();

        public string UserAnswer { get; set; }
        public bool IsCorrect { get; set; }
        private int Calculate()
        {
            return Operator == '+' ? Num1 + Num2 : Num1 - Num2;
        }

        public void Generate()
        {
            var rand = new Random();
            Num1 = rand.Next(0, 100);
            Num2 = rand.Next(0, 100);
            Operator = rand.Next(2) == 0 ? '+' : '-';
        }
    }
}
