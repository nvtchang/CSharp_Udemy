using System;

namespace Coding.Exercise
{
    public static class StringsTransformator
    {
        public static string TransformSeparators(
            string input,
            string originalSeparator,
            string targetSeparator)
        {
            //your code goes here
            string [] result = input.Split(originalSeparator);
            string taregt = string.Join(targetSeparator, result);

            return taregt;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}