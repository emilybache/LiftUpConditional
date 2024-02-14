package codingdojo;

public class ConditionalClass {

    public static String LiftUpConditional(boolean a, boolean b)
    {
        if (a)
        {
            if (b)
            {
                return "ATrueBTrue";
            }
            else
            {
                return "ATrueBFalse";
            }
        }
        else
        {
            if (b)
            {
                return "AFalseBTrue";
            }
            else
            {
                return "AFalseBFalse";
            }
        }
    }
}