using NUnit.Framework;
using System;

public class PsyfocusCalculatorTests
{
    [Test]
    public void CalculatePsyfocusRegeneration_ValidInput_ReturnsCorrectRegeneration()
    {
        float psychicSensitivity = 1.0f;
        float deltaTime = 1.0f;
        float expectedRegeneration = 0.5f;

        float actualRegeneration = PsyfocusCalculator.CalculatePsyfocusRegeneration(psychicSensitivity, deltaTime);

        Assert.That(actualRegeneration, Is.EqualTo(expectedRegeneration));
    }

    [Test]
    public void CalculatePsyfocusRegeneration_HighSensitivity_ReturnsCorrectRegeneration()
    {
        float psychicSensitivity = 10.0f;
        float deltaTime = 1.0f;
        float expectedRegeneration = 5.0f;

        float actualRegeneration = PsyfocusCalculator.CalculatePsyfocusRegeneration(psychicSensitivity, deltaTime);

        Assert.That(actualRegeneration, Is.EqualTo(expectedRegeneration));
    }

    [Test]
    public void CalculatePsyfocusRegeneration_LowSensitivity_ReturnsCorrectRegeneration()
    {
        float psychicSensitivity = 0.1f;
        float deltaTime = 1.0f;
        float expectedRegeneration = 0.05f;

        float actualRegeneration = PsyfocusCalculator.CalculatePsyfocusRegeneration(psychicSensitivity, deltaTime);

        Assert.That(actualRegeneration, Is.EqualTo(expectedRegeneration).Within(0.0001));
    }

    [Test]
    public void CalculatePsyfocusRegeneration_ZeroDeltaTime_ReturnsZeroRegeneration()
    {
        float psychicSensitivity = 1.0f;
        float deltaTime = 0.0f;
        float expectedRegeneration = 0.0f;

        float actualRegeneration = PsyfocusCalculator.CalculatePsyfocusRegeneration(psychicSensitivity, deltaTime);

        Assert.That(actualRegeneration, Is.EqualTo(expectedRegeneration));
    }

    [Test]
    public void CalculatePsyfocusRegeneration_LargeDeltaTime_ReturnsCorrectRegeneration()
    {
        float psychicSensitivity = 1.0f;
        float deltaTime = 100.0f;
        float expectedRegeneration = 50.0f;

        float actualRegeneration = PsyfocusCalculator.CalculatePsyfocusRegeneration(psychicSensitivity, deltaTime);

        Assert.That(actualRegeneration, Is.EqualTo(expectedRegeneration));
    }

    [Test]
    public void CalculatePsyfocusRegeneration_NegativeDeltaTime_ThrowsArgumentOutOfRangeException()
    {
        float psychicSensitivity = 1.0f;
        float deltaTime = -1.0f;

        Assert.Throws<ArgumentOutOfRangeException>(() => PsyfocusCalculator.CalculatePsyfocusRegeneration(psychicSensitivity, deltaTime));
    }

    [Test]
    public void CalculatePsyfocusRegeneration_SensitivityTooLow_ThrowsArgumentOutOfRangeException()
    {
        float psychicSensitivity = 0.0f;
        float deltaTime = 1.0f;

        Assert.Throws<ArgumentOutOfRangeException>(() => PsyfocusCalculator.CalculatePsyfocusRegeneration(psychicSensitivity, deltaTime));
    }

    [Test]
    public void CalculatePsyfocusRegeneration_SensitivityTooHigh_ThrowsArgumentOutOfRangeException()
    {
        float psychicSensitivity = 11.0f;
        float deltaTime = 1.0f;

        Assert.Throws<ArgumentOutOfRangeException>(() => PsyfocusCalculator.CalculatePsyfocusRegeneration(psychicSensitivity, deltaTime));
    }

    [Test]
    public void CalculatePsyfocusRegeneration_DecimalSensitivityAndDeltaTime_ReturnsCorrectRegeneration()
    {
        float psychicSensitivity = 2.5f;
        float deltaTime = 0.5f;
        float expectedRegeneration = 0.625f;

        float actualRegeneration = PsyfocusCalculator.CalculatePsyfocusRegeneration(psychicSensitivity, deltaTime);

        Assert.That(actualRegeneration, Is.EqualTo(expectedRegeneration).Within(0.0001));
    }
}