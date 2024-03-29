﻿using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        int Age { get; }
        char Sex { get; }

        void AddGrade(float grade);
        void AddGrade(int grade);
        void AddGrade(long grade);
        void AddGrade(double grade);
        void AddGrade(string grade);
        void AddGrade(char grade);

        event GradeAddedDelegate GradeAdded;

        Statistics GetStatistics(); 
    }
}
