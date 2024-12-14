namespace TechCraftsmen.ProjectEuler.Application.Problems;

public class Problem1 : AbstractProblem
{
    public Problem1(int index): base(index)
    {
        ExpectedParameters.Add("range", typeof(int));
    }

    public override object Resolve(Dictionary<string, object> input)
    {
        ValidateInput(input);

        var range = (int)(input.GetValueOrDefault("range") ?? throw new ArgumentException("Could not cast parameter \"range\""));
        
        return SumMultiplesOfThreeAndFive(range);
    }
    
    private static int SumMultiplesOfThreeAndFive(int range)
    {
        var sum = 0;
		
        for (var i = 1; i < range; i++)
        {
            var multipleOfThree = i % 3 == 0;
            var multipleOfFive = i % 5 == 0;
			
            if (multipleOfThree || multipleOfFive) 
            {
                sum += i;
            }
        }
		
        return sum;
    }
}