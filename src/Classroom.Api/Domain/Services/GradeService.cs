using Classroom.Api.Infrastructure.Persistence;

namespace Classroom.Api.Domain.Services;

public class GradeService
{
    private readonly SqlGradeRepository _repository = new();

    public int GetScore(int midterm, int finalExam)
    {
        return _repository.CalculateFinalScore(midterm, finalExam);
    }
}
