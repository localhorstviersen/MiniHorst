using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetTest.DeepHorst
{
    class Layer
    {
        private int index;
        private SortedList<int,Neuron> neurons;

        public Layer()
        {
            index = 0;
            neurons = new SortedList<int, Neuron>();
        }

        public void AddNeuron(Neuron neuron)
        {
            neurons.Add(index,neuron);
            this.index++;
        }

        public SortedList<int,Neuron> GetNeurons()
        {
            return this.neurons;
        }
    }
}
