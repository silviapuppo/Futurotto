using System;
using CreatingAndUsingObjects;

namespace Exercise05
{
    public class CatsCreator
    {
        public static Cat[] CreateTenCats()
        {
            Cat[] catFamily = new Cat[10];

            Cat cat0 = new Cat();
            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            Cat cat3 = new Cat();
            Cat cat4 = new Cat();
            Cat cat5 = new Cat();
            Cat cat6 = new Cat();
            Cat cat7 = new Cat();
            Cat cat8 = new Cat();
            Cat cat9 = new Cat();

            for(int i = 0; i < catFamily.Length; i++)
            {
                catFamily[i] = new Cat("Cat" + Sequence.NextValue(), "Red" );
            }

            return catFamily;
        }
    }
}
