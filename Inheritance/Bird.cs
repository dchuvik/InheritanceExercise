using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class
    internal class Bird : Animal
    {
    public Bird()
    {
    }
        public string size { get; set; }
        public string feathersColor { get; set; }
        public string birdType { get; set; }
        public bool canFly { get; set; }



    }
}
