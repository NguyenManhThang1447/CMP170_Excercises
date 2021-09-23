using System;

namespace Ex_Topic3
{
        interface IAnimal
        {
            void Move();
            void Speak();
        }
        public abstract class BaseAnimal : IAnimal
        {


            public abstract void Move();


            public abstract void Speak();
        }
        public class Monkey : BaseAnimal
        {

            public override void Move()
            {
                Console.WriteLine("Monke is walking.");
            }
            public override void Speak()
            {
                Console.WriteLine("Monke say kih kih kah kah.");
            }
        }
        public class Pets : BaseAnimal
        {
            public string name { get; set; }

            public Pets(string name)
            {
                this.name = name;
            }


            public override void Move()
            {
                Console.WriteLine(" is walking.");
            }


            public override void Speak()
            {
                Console.WriteLine(" is speaking");
            }
        }
        public class Dogs : Pets
        {
            public Dogs(string name) : base(name)
            {
            }

            public override void Move()
            {
                Console.WriteLine(name + " dog is walking with 4 legs.");
            }
            public override void Speak()
            {
                Console.WriteLine(name + " dog say gau gau");
            }
        }
        public class Cats : Pets
        {
            public Cats(string name) : base(name)
            {
            }


            public override void Move()
            {
                Console.WriteLine(name + " cat is walking with 4 legs.");
            }
            public override void Speak()
            {
                Console.WriteLine(name + " cat say meo meo");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                List<IAnimal> animals = new List<IAnimal>();
                animals.Add(new Dogs("Shiba"));
                animals.Add(new Monkey());
                animals.Add(new Cats("beagel"));


                foreach (IAnimal animal in animals)
                {
                    animal.Move();
                    animal.Speak();
                }

                Console.ReadLine();
            }
        }
    }