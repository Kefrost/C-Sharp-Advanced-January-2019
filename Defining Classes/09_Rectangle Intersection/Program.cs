using System;
using System.Collections.Generic;
using System.Linq;

namespace rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rectangle> rectangles = new List<Rectangle>();

            int[] rectanglesCountsAndIntersectsCounts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rectanglesCount = rectanglesCountsAndIntersectsCounts[0];
            int intersectsCountToCheck = rectanglesCountsAndIntersectsCounts[1];

            for (int i = 0; i < rectanglesCount; i++)
            {
                string[] rectangleTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string id = rectangleTokens[0];
                double width = double.Parse(rectangleTokens[1]);
                double height = double.Parse(rectangleTokens[2]);
                double coordinateX = double.Parse(rectangleTokens[3]);
                double coordinateY = double.Parse(rectangleTokens[4]);

                Rectangle rectangle = new Rectangle(id, width, height, coordinateX, coordinateY);

                rectangles.Add(rectangle);
            }

            for (int i = 0; i < intersectsCountToCheck; i++)
            {
                string[] rectanglesNamesToCheck = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstRectangleId = rectanglesNamesToCheck[0];
                string secondRectangleId = rectanglesNamesToCheck[1];

                Rectangle fRec = rectangles.FirstOrDefault(x => x.Id == firstRectangleId);
                Rectangle sRec = rectangles.FirstOrDefault(x => x.Id == secondRectangleId);

                if (fRec.Intersect(sRec))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }

        }
    }
}
