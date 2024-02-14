package codingdojo;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class ConditionalClassTest {
    @Test
    void aTrueBTrue() {
        assertEquals("ATrueBTrue", ConditionalClass.LiftUpConditional(true, true));
    }

    @Test
    void aTrueBFalse() {
        assertEquals("ATrueBFalse", ConditionalClass.LiftUpConditional(true, false));
    }

    @Test
    void aFalseBTrue() {
        assertEquals("AFalseBTrue", ConditionalClass.LiftUpConditional(false, true));
    }

    @Test
    void aFalseBFalse() {
        assertEquals("AFalseBFalse", ConditionalClass.LiftUpConditional(false, false));
    }

}
