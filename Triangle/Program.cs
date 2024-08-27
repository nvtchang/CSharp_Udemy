using System;

namespace Coding.Exercise
{
    public class Triangle
    {
        //your code goes here
        int Base;
        int Height;

        public Triangle(int _base, int _height) {
            Base = _base;
            Height = _height;
        }

        public int CalculateArea()
        {
            return ((Base * Height) / 2);
        }

        public string AsString()
        {
            return "Base is " + Base + "Height is " + Height;
        }

    }
} 


