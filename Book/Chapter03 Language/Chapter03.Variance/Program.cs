using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter03.Variance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Animal[] animals = new Elephant[10];

            //Will throw an exception at runtime
            animals[0] = new Animal();


            //The last line of the following block will not compile
            List<Animal> Animals = new List<Animal>();
            //This will work fine as we can be sure Elephant has all Animal's properties
            Animals.Add(new Elephant());
            List<Elephant> Elephants = new List<Elephant>();
            //This will not compile
            //Elephants.Add(new Animal());


           
        }


        public void VarianceInDotNet4()
        {
             //This wont work prior to .net 4
            IList<Elephant> elephants = new List<Elephant>();
            IEnumerable<Animal> animals = elephants;
        }

        public void WeightComparer()
        {
            WeightComparer objAnimalComparer = new WeightComparer();
            List<Animal> Animals = new List<Animal>();
            Animals.Add(new Animal("elephant", 500));
            Animals.Add(new Animal("tiger", 100));
            Animals.Add(new Animal("rat", 5));
            //Works
            Animals.Sort(objAnimalComparer);
            List<Elephant> Elephants = new List<Elephant>();
            Elephants.Add(new Elephant("Nellie", 100));
            Elephants.Add(new Elephant("Dumbo", 200));
            Elephants.Add(new Elephant("Baba", 50));
            //Doesn't work prior to .net 4
            Elephants.Sort(objAnimalComparer);
            Elephants.ForEach(e => Console.WriteLine(e.Name + " " + e.Weight.ToString()));
        }
    }
}
