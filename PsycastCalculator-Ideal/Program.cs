public class PsycastCalculator
{
    private const float RegenerationFactor = 0.5f;

    public static float CalculatePsyfocusRegeneration(float psychicSensitivity, float deltaTime)
    {
        // Validate input
        if (psychicSensitivity < 0.1f || psychicSensitivity > 10.0f)
        {
            throw new ArgumentOutOfRangeException(nameof(psychicSensitivity), "Psychic sensitivity must be between 0.1 and 10.0.");
        }

        return psychicSensitivity * deltaTime * RegenerationFactor;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Result: {0}", PsycastCalculator.CalculatePsyfocusRegeneration(.8f, 5f));
    }
}