using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public Reptile()
        {
        }

        public string size { get; set; }
        public string skinColor { get; set; }
        public string reptileType { get; set; }
        public bool canRegenerate { get; set; }
    }
}
