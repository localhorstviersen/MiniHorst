using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuralNetTest.DeepHorst.ActivationFunctions;

namespace NeuralNetTest.DeepHorst
{
    class Network
    {
        public Network()
        {
            Layer input = new Layer();
            Layer hidden = new Layer();
            Layer output = new Layer();

            for (int i = 0; i < 4; i++)
            {
                InputNeuron neuron = new InputNeuron();
                neuron.SetActivationFunction(new Plain());
                input.AddNeuron(neuron);
            }

            for(int i=0; i<9; i++)
            {
                Neuron neuron = new Neuron();
                neuron.SetActivationFunction(new Sigmoid());
                SortedList<int,Neuron> neurons = input.GetNeurons();

                foreach(Neuron n in neurons.Values)
                {
                    NeuronConnection con = new NeuronConnection(n, neuron);
                    neuron.AddConnection(con);
                }

                hidden.AddNeuron(neuron);
            }

            for(int i=0; i<1; i++)
            {
                Neuron neuron = new Neuron();
                neuron.SetActivationFunction(new Sigmoid());
                SortedList<int, Neuron> neurons = hidden.GetNeurons();

                foreach (Neuron n in neurons.Values)
                {
                    NeuronConnection con = new NeuronConnection(n, neuron);
                    neuron.AddConnection(con);
                }

                output.AddNeuron(neuron);
            }

            foreach (InputNeuron n in input.GetNeurons().Values)
            {
                Random r = new Random();
                n.SetInputValue((float)r.NextDouble());
            }

            foreach(Neuron n in output.GetNeurons().Values)
            {
                float result = n.GetOutput();
            }
        }
    }
}
