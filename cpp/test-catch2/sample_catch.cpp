#include "ApprovalTests.hpp"
#include "catch2/catch.hpp"

#include "sample.h"

TEST_CASE ("Sample") {
    REQUIRE("ATrueBTrue" ==   ConditionalClass::LiftUpConditional(true, true));
    REQUIRE("ATrueBFalse" ==  ConditionalClass::LiftUpConditional(true, false));
    REQUIRE("AFalseBTrue" ==  ConditionalClass::LiftUpConditional(false, true));
    REQUIRE("AFalseBFalse" == ConditionalClass::LiftUpConditional(false, false));
}


