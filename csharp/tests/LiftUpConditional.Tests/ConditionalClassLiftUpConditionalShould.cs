namespace LiftUpConditional.Tests;

public class ConditionalClassLiftUpConditionalShould
{
    [Theory]
    [InlineData(true, true)]
    [InlineData(true, false)]
    [InlineData(false, true)]
    [InlineData(false, false)]
    public void Give_AValueBValue(bool a, bool b)
    {
        Assert.Equal($"A{a}B{b}", ConditionalClass.LiftUpConditional(a, b));
    }
}
