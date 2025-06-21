namespace MathQuizApp.Models
{
    public class MPViewModel
    {
        public MPViewModel(MathProblem problem)
        {
            Num1 = problem.Num1;
            Num2 = problem.Num2;
            Operator = problem.Operator;
        }
        
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
        
    }
}