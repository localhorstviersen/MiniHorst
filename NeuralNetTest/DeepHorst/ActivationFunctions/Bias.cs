using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetTest.DeepHorst.ActivationFunctions
{
    class Bias : ActivationFunction
    {
        public float Calc(float inputValue)
        {
            return 1.0f;
        }
    }
}
