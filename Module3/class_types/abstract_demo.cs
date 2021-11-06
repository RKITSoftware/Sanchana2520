﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract__demo
{
    public abstract class Shape
    {
        public abstract void draw();
    }
    public class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle...");
        }  
        static void Main(string[] args)
        {
            objShape obj;
            obj = new Rectangle();
            obj.draw();
            obj = new Circle();
            obj.draw();  
        }
    }
}
