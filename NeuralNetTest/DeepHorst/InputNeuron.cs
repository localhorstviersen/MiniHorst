﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetTest.DeepHorst
{
    class InputNeuron : Neuron
    {
        private float inputValue;

        public void SetInputValue(float value)
        {
            this.inputValue = value;
        }
    }
}
