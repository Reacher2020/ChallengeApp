using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace ChallengeApp
{
    internal class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname, int age, char sex)
            : base(name, surname, age, sex)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Grade value out of range");
            }
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(long grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is'n float");
            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong lrtter");
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            result.Average = 0f;
            result.Max = float.MinValue;
            result.Min = float.MaxValue;
            var counter = 0;

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        result.Min = Math.Min(result.Min, number);
                        result.Max = Math.Max(result.Max, number);
                        result.Average += number;
                        counter++;
                    }
                }
            }
            result.Average /= counter;

            switch (result.Average)
            {
                case var average when average >= 80:
                    result.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    result.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    result.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    result.AverageLetter = 'D';
                    break;
                default:
                    result.AverageLetter = 'E';
                    break;

            }
            return result;
        }
    }
    }
}
