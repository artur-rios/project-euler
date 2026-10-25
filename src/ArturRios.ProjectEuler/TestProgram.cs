using ArturRios.ProjectEuler.Problems;

namespace ArturRios.ProjectEuler;

public class TestProgram
{
        public static void Main()
        {
                var solution = LargestPrimeFactor.Solution(600851475143);
                
                Console.WriteLine(solution);
        }
}