using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuralNetTest.DeepHorst.ActivationFunctions;

namespace NeuralNetTest.DeepHorst
{
    class Neuron
    {
        private ActivationFunction activationFunction;
        private SortedList<int, NeuronConnection> inputNeurons;
        private int inputIndex;

        public Neuron()
        {
            inputNeurons = new SortedList<int, NeuronConnection>();
            inputIndex = 0;
        }

        public void SetActivationFunction(ActivationFunction activationFunction)
        {
            this.activationFunction = activationFunction;
        }

        public void AddConnection(NeuronConnection neuronConnection)
        {
            inputNeurons.Add(inputIndex, neuronConnection);
            inputIndex++;
        }

        public float GetOutput()
        {
            return activationFunction.Calc(GetWeightedSum());
        }

        public float GetWeightedSum()
        {
            float sum = 0;
            foreach(NeuronConnection con in inputNeurons.Values)
            {
                sum += con.GetSource().GetOutput() * con.GetWeight();
            }

            return sum;
        }
    }
}
