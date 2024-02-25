namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
 
        public void AddGrade(float grade)
        {
            if(grade >=0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Grade value out of range");
            }
        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is'n float");
            }
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(long grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average =  0f;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithForeach()
        {
            var statistics = new Statistics();

            statistics.Average = 0f;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticWithFor()
        {
            var statistics = new Statistics();

            statistics.Average = 0f;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (var index = 0; index < grades.Count; index++)
            {
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Average += grades[index];
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticWithDoWhile()
        {
            var statistics = new Statistics();

            statistics.Average = 0f;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0; ;

            do 
            {
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Average += this.grades.Count;
                index++;
            }
            while(index<this.grades.Count);

            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticWithWhile()
        {
            var statistics = new Statistics();

            statistics.Average = 0f;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0; ;

            while (index < this.grades.Count) ;
            {
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Average += this.grades.Count;
                index++;
            }
            
            statistics.Average /= this.grades.Count;
            return statistics;
        }

    }
}