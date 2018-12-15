﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Zoo
    {
        public List<Animal> Animals { get; set; }

        public Zoo()
        {
            Animals = new List<Animal>();
            InitZoo();
        }

        private void InitZoo()
        {
            Animals.Add(new Animal("Elephant", Gender.Female));
            Animals.Add(new Animal("Tiger", Gender.Male));
            Animals.Add(new Animal("Zebra", Gender.Female));
            Animals.Add(new Animal("Fox", Gender.Female));
        }
    }
}
