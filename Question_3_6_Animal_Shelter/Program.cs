using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3_6_Animal_Shelter
{
    class Program
    {
        //        Animal Shelter: An animal shelter, which holds only dogs and cats, operates on a strictly "first in, first
        //out" basis. People must adopt either the "oldest" (based on arrival time) of all animals at the shelter,
        //or they can select whether they would prefer a dog or a cat(and will receive the oldest animal of
        //that type). They cannot select which specific animal they would like.Create the data structures to
        //maintain this system and implement operations such as enqueue, dequeueAny, dequeueDog,
        //and dequeueCat.You may use the built-in LinkedList data structure.
        static void Main(string[] args)
        {
        }
        public class AnimalShelter
        {
            public readonly LinkedList<Cat> Cats;
            public readonly LinkedList<Dog> Dogs;
            public AnimalShelter()
            {
                Cats = new LinkedList<Cat>();
                Dogs = new LinkedList<Dog>();
            }
            public void Enqueue(Animal animal)
            {
                //this creates a queue that has dogs and cats
                var cat = animal as Cat;
                var dog = animal as Dog;
                //add each cat to end of cat linked list, and which it links back to previous cat
                if (cat != null)
                    Cats.AddLast(cat);
                else if (dog != null)
                    Dogs.AddLast(dog);
                else
                    throw new Exception("this type of animal shouldnt be here");

            }
            public Animal DequeueAny()
            {
                if (Cats.Count() == 0 && Dogs.Count() == 0)
                    throw new Exception("no anmial in shelter");
                var catEnqueueTIme = new DateTimeOffset();
                var dogEnqueueTIme = new DateTimeOffset();
                //compare which animal has earlest datatime and remove that animal
                if (Cats.First.Value.ArrivalTime != null)
                {
                    catEnqueueTIme = Cats.First.Value.ArrivalTime;
                }
                else
                    catEnqueueTIme = DateTimeOffset.MaxValue;
                if (Dogs.First.Value.ArrivalTime != null)
                {
                    dogEnqueueTIme = Dogs.First.Value.ArrivalTime;
                }
                else
                    dogEnqueueTIme = DateTimeOffset.MaxValue;
                if (dogEnqueueTIme > catEnqueueTIme)
                    return DequeueCat();
                else
                    return DequeueDog();
            }
            //since we add cat to cat from back, so the oldest cat must be head of linkedlist, so if we remove by frist,the oldest will be removed
            public Cat DequeueCat()
            {
                if (Cats.Count == 0)
                    throw new Exception("no cats");
                var pickedCat = Cats.First.Value;
                Cats.RemoveFirst();
                return pickedCat;                
            }
            public Dog DequeueDog()
            {
                if (Dogs.Count == 0)
                    throw new Exception("no dogs");
                var pickedDog = Dogs.First.Value;
                Dogs.RemoveFirst();
                return pickedDog;
            }
        }

        public class Dog : Animal
        {
            public Dog(int id):base(id)
            {

            }
        }
        //inheret from animal and share same id
        public class Cat:Animal
        {
            public Cat(int id) : base(id)
            {

            }
        }
        //abstract animal cass
        public abstract class Animal
        {
            public int Id { get; set; }
            public DateTimeOffset ArrivalTime {get;set;}
            public Animal(int id)
            {
                Id = id;
                ArrivalTime = DateTime.Now;
            }
        }
       
    }
}
