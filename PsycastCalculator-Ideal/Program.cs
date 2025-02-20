using System;

public class PsyfocusCalculator
{
    /// <summary>
    /// Calculates the amount of psyfocus regenerated over a given time interval.
    /// </summary>
    /// <param name="psychicSensitivity">A float representing the character's psychic sensitivity (range: 0.1 to 10.0).</param>
    /// <param name="deltaTime">A float representing the time elapsed since the last calculation, in seconds.</param>
    /// <returns>The amount of psyfocus regenerated as a float.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown if psychicSensitivity is outside the valid range (0.1 to 10.0) or if deltaTime is negative.
    /// </exception>
    public static float CalculatePsyfocusRegeneration(float psychicSensitivity, float deltaTime)
    {
        if (psychicSensitivity < 0.1f || psychicSensitivity > 10.0f)
        {
            throw new ArgumentOutOfRangeException(nameof(psychicSensitivity), "PsychicSensitivity must be between 0.1 and 10.0.");
        }

        if (deltaTime < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(deltaTime), "DeltaTime must be non-negative.");
        }

        return psychicSensitivity * 0.5f * deltaTime;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Result: {0}", PsyfocusCalculator.CalculatePsyfocusRegeneration(.8f, 1f));
    }
}