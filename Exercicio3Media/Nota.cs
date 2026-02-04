namespace ExercicioFixacao3
{
    class GradeCalculator
    {
        public string StudentName = "";
        public double Grade1;
        public double Grade2;
        public double Grade3;

        public double FinalGrade()
        {
            return Grade1 + Grade2 + Grade3;
        }

        public bool IsPassed()
        {
            if(FinalGrade() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double MissingPoints()
        {
            if (!IsPassed())
            {
                return 60.0 - FinalGrade();
            }
            else
            {
                return 0.0;
            }
        }

    }
}