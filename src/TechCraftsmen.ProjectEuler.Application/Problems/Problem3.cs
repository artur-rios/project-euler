namespace TechCraftsmen.ProjectEuler.Application.Problems;

public class Problem3 : AbstractProblem
{
    public Problem3(int index) : base(index)
    {
        Title = "Largest Prime Factor";
        Objective = "What is the largest prime factor of a given number?";
        ExpectedParameters.Add("numberToFactor", typeof(int));
    }
    
    public override object Resolve(Dictionary<string, object> input)
    {
        ValidateInput(input);
        
        var numberToFactor = (int)(input.GetValueOrDefault("numberToFactor") ?? throw new ArgumentException("Could not cast parameter \"numberToFactor\""));

        throw new NotImplementedException();
    }
}