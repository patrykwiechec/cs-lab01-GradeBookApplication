using System;
using System.Collections.Generic;
using System.Text;


namespace GradeBook.GradeBooks
{
    public class  RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)

                throw new InvalidOperationException("You need more then 5 students");

            else
            {
                if (averageGrade >= 80)
                    return 'A';
                else if (averageGrade >= 60)
                    return 'B';
                else if (averageGrade >= 30)
                    return 'C';
                else if (averageGrade >= 20)
                    return 'D';
                else
                    return 'F';
            }

        }



    }
}
