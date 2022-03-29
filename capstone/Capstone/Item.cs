using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public string Type { get; set; }

        public string Position { get; set; }
        //abstract Eatproduct method for child class
        //every child class will have a eatproduct method that will display eating
        //drink, gum, etc child class
    }
}

