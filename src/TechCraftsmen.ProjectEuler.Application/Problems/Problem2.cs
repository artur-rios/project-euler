namespace TechCraftsmen.ProjectEuler.Application.Problems;

public class Problem2 : AbstractProblem
{
    public Problem2(int index) : base(index)
    {
        ExpectedParameters.Add("limit", typeof(int));
    }
    
    public override object Resolve(Dictionary<string, object> input)
    {
        ValidateInput(input);
        
        var limit = (int)(input.GetValueOrDefault("limit") ?? throw new ArgumentException("Could not cast parameter \"range\""));

        var current = 1;
        var previous = current;
        var sum = 0;

        while (current <= limit)
        {
            var aux = current;
            
            current += previous;

            previous = aux;
            
            if (current % 2 == 0)
            {
                sum += current;
            }
        }

        return sum;
    }
}