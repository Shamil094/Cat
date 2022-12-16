using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{
    internal class Cat
    {
        public delegate void OperationCat();
        private string mood;    //Main methodunda istifade etmek ucun ne etmeli???
                                //public olsa kenardan deyishmek olur//get-set(property kimi) ile set`i baglasaq methodla da deyismek olmur
        private string hungry;
        private string energy;

        public void Play()
        {
            mood = "good";
            hungry = "yes";
            energy = "low";
        }
        public void Feed()
        {
            mood = "good";
            hungry = "no";
            energy = "high";
        }
        public void Sleep()
        {
            mood = "tired";
            hungry = "yes";
            energy = "high";
        }
        public void Apply(OperationCat OC)
        {
            OC.Invoke();
        }
    }
}
