#ifndef SAMPLE_H
#define SAMPLE_H

#include <string>

using namespace  std;

class ConditionalClass {

public:
    static string LiftUpConditional(bool a, bool b)
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
};

#endif //SAMPLE_H
