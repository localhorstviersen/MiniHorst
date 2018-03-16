using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetTest.DeepHorst
{
    class NeuronConnection
    {
        private Neuron Source;
        private Neuron Destination;
        private float Weight;

        public NeuronConnection(Neuron Source, Neuron Destination)
        {
            this.Source = Source;
            this.Destination = Destination;

            Random r = new Random();
            float rand = r.Next(0, 100);
            Weight = rand / 100;
        }

        public Neuron GetSource() { return Source; }
        public Neuron GetDestination(){ return Destination; }
        public float GetWeight() { return Weight; }

        public void SetSource(Neuron Source) { this.Source = Source; }
        public void SetDestination(Neuron Destination) { this.Destination = Destination; }
        public void SetWeight(float Weight) { this.Weight = Weight; }
    }
}
