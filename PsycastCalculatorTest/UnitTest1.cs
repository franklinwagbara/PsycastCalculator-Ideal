using NUnit.Framework;

[TestFixture]
public class PsycastCalculatorTests
{
    [Test]
    public void CalculatePsyfocusRegeneration_ValidInput_ReturnsCorrectRegeneration()
    {
        float psychicSensitivity = 1.0f;
        float deltaTime = 1.0f;
        float expectedRegeneration = 0.5f;

        float actualRegeneration = PsycastCalculator.CalculatePsyfocusRegeneration(psychicSensitivity, deltaTime);

        Assert.That(actualRegeneration, Is.EqualTo(expectedRegeneration).Within(0.001f));
    }

    [Test]
    public void CalculatePsyfocusRegeneration_HighSensitivity_ReturnsCorrectRegeneration()
    {
        float psychicSensitivity = 10.0f;
        float deltaTime = 0.5f;
        float expectedRegeneration = 2.5f;

        float actualRegeneration = PsycastCalculator.CalculatePsyfocusRegeneration(psychicSensitivity, deltaTime);

        Assert.That(actualRegeneration, Is.EqualTo(expectedRegeneration).Within(0.001f));
    }

    [Test]
    public void CalculatePsyfocusRegeneration_LowSensitivity_ReturnsCorrectRegeneration()
    {
        float psychicSensitivity = 0.1f;
        float deltaTime = 2.0f;
        float expectedRegeneration = 0.1f;

        float actualRegeneration = PsycastCalculator.CalculatePsyfocusRegeneration(psychicSensitivity, deltaTime);

        Assert.That(actualRegeneration, Is.EqualTo(expectedRegeneration).Within(0.001f));
    }

    [Test]
    public void CalculatePsyfocusRegeneration_ZeroDeltaTime_ReturnsZeroRegeneration()
    {
        float psychicSensitivity = 5.0f;
        float deltaTime = 0.0f;
        float expectedRegeneration = 0.0f;

        float actualRegeneration = PsycastCalculator.CalculatePsyfocusRegeneration(psychicSensitivity, deltaTime);

        Assert.That(actualRegeneration, Is.EqualTo(expectedRegeneration).Within(0.001f));
    }

    [Test]
    public void CalculatePsyfocusRegeneration_LargeDeltaTime_ReturnsCorrectRegeneration()
    {
        float psychicSensitivity = 2.0f;
        float deltaTime = 10.0f;
        float expectedRegeneration = 10.0f;

        float actualRegeneration = PsycastCalculator.CalculatePsyfocusRegeneration(psychicSensitivity, deltaTime);

        Assert.That(actualRegeneration, Is.EqualTo(expectedRegeneration).Within(0.001f));
    }

    [Test]
    public void CalculatePsyfocusRegeneration_SensitivityAtMinimum_ReturnsCorrectRegeneration()
    {
        float psychicSensitivity = 0.1f;
        float deltaTime = 1.0f;
        float expectedRegeneration = 0.05f;

        float actualRegeneration = PsycastCalculator.CalculatePsyfocusRegeneration(psychicSensitivity, deltaTime);

        Assert.That(actualRegeneration, Is.EqualTo(expectedRegeneration).Within(0.001f));
    }

    [Test]
    public void CalculatePsyfocusRegeneration_SensitivityAtMaximum_ReturnsCorrectRegeneration()
    {
        float psychicSensitivity = 10.0f;
        float deltaTime = 1.0f;
        float expectedRegeneration = 5.0f;

        float actualRegeneration = PsycastCalculator.CalculatePsyfocusRegeneration(psychicSensitivity, deltaTime);

        Assert.That(actualRegeneration, Is.EqualTo(expectedRegeneration).Within(0.001f));
    }

    [Test]
    public void CalculatePsyfocusRegeneration_SensitivityBelowMinimum_ThrowsArgumentOutOfRangeException()
    {
        float psychicSensitivity = 0.09f;
        float deltaTime = 1.0f;

        Assert.Throws<ArgumentOutOfRangeException>(() => PsycastCalculator.CalculatePsyfocusRegeneration(psychicSensitivity, deltaTime));
    }

    [Test]
    public void CalculatePsyfocusRegeneration_SensitivityAboveMaximum_ThrowsArgumentOutOfRangeException()
    {
        float psychicSensitivity = 10.1f;
        float deltaTime = 1.0f;

        Assert.Throws<ArgumentOutOfRangeException>(() => PsycastCalculator.CalculatePsyfocusRegeneration(psychicSensitivity, deltaTime));
    }

}