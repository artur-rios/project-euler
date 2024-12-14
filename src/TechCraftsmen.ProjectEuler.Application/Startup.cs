using TechCraftsmen.ProjectEuler.Application.Problems;

namespace TechCraftsmen.ProjectEuler.Application;

public static class Startup
{
    private static readonly List<AbstractProblem> Problems = [
        new Problem1(1),
        new Problem2(2)
    ];

    public static AbstractProblem? GetProblemByIndex(int index)
    {
        return Problems.Find(problem => problem.Index == index);
    }
}