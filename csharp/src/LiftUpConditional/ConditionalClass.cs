namespace LiftUpConditional;
public static class ConditionalClass
{
    private static string ATrueBTrue() => nameof(ATrueBTrue);

    private static string ATrueBFalse() => nameof(ATrueBFalse);

    private static string AFalseBTrue() => nameof(AFalseBTrue);

    private static string AFalseBFalse() => nameof(AFalseBFalse);

    public static string LiftUpConditional(bool a, bool b)
    {
        if (a)
        {
            if (b)
            {
                return ATrueBTrue();
            }
            else
            {
                return ATrueBFalse();
            }
        }
        else
        {
            if (b)
            {
                return AFalseBTrue();
            }
            else
            {
                return AFalseBFalse();
            }
        }
    }
}
