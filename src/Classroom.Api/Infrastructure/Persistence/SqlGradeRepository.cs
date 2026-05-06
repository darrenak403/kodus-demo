namespace Classroom.Api.Infrastructure.Persistence;

public class SqlGradeRepository
{
    public int CalculateFinalScore(int midterm, int finalExam) => (midterm + finalExam) / 2;
}
