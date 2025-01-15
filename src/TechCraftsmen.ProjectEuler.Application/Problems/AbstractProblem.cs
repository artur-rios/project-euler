namespace TechCraftsmen.ProjectEuler.Application.Problems;

public abstract class AbstractProblem(int index)
{
    public int Index { get; } = index;
    public string Title { get; set;  }
    public string Objective { get; set; }

    public readonly Dictionary<string, Type> ExpectedParameters = [];

    public abstract object Resolve(Dictionary<string, object> input);

    internal void ValidateInput(Dictionary<string, object> input)
    {
        if (input.Count != ExpectedParameters.Count)
        {
            throw new ArgumentException("Insufficient parameters passed");
        }

        foreach (var parameter in ExpectedParameters)
        {
            if (!input.TryGetValue(parameter.Key, out var value))
            {
                throw new ArgumentException($"Expected parameter \"{parameter.Key}\" not found");
            }

            if (value.GetType() != parameter.Value)
            {
                throw new ArgumentException($"Incorrect value type passed as the parameter \"{parameter.Key}\".\nExpected {parameter.Value.Name} | Passed {value.GetType().Name}");
            }
        }
    }
}