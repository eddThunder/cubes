

using CubeUtils;
using CubeUtils.Interfaces;
using CubeUtils.Models;
using System;

namespace CubesConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICubeManager cubeManager = new CubeManager();

            Console.WriteLine("Insert cube 1");
            Console.WriteLine("-----------------------");
            Cube cube1 = SetCubeProperties();

            Console.WriteLine("");

            Console.WriteLine("Insert cube 2");
            Console.WriteLine("-----------------------");
            Cube cube2 = SetCubeProperties();



            if (cubeManager.HasCollision(cube1, cube2))
            {
                Console.WriteLine("Collision");

                float volume = cubeManager.GetIntersectionVolume(cube1, cube2);
                Console.WriteLine("Intersection volume: {0}", volume);
            }
            else
            {
                Console.WriteLine("No collision found");
            }

            Console.ReadLine();
        }

        static Cube SetCubeProperties()
        {
            Cube cube = new Cube();
            cube.SideSize = GetCubeSize();

            Console.WriteLine("Insert coordinate for X axis");
            cube.CenterPosition.X = GetCoordinateNumber();

            Console.WriteLine("Insert coordinate for Y axis");
            cube.CenterPosition.Y = GetCoordinateNumber();

            Console.WriteLine("Insert coordinate for Z axis");
            cube.CenterPosition.Z = GetCoordinateNumber();

            return cube;
        }

        static float GetCoordinateNumber()
        {
            bool parseSuccess = false;
            float num = 0;

            do
            {
                Console.WriteLine("Please insert a valid axis value");
                parseSuccess = float.TryParse(Console.ReadLine(), out num);
            }
            while (!parseSuccess);

            return num;
        }

        static float GetCubeSize()
        {
            float cubeSize = 0;
            bool parseSuccess = false;
            do
            {
                Console.WriteLine("Please insert a number for cube size");
                parseSuccess = float.TryParse(Console.ReadLine(), out cubeSize);

            } while(cubeSize < 0 || !parseSuccess);

            return cubeSize;
        }
    }
}
