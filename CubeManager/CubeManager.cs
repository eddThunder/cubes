using CubeManager.Interfaces;
using CubeManager.Models;

namespace CubeUtils
{
    public class CubeManager : ICubeManager
    {
        public CubeManager() { }

        public int GetIntersectionVolume(Cube cube1, Cube cube2)
        {
            var initPosCube1 = GetFirstCubeMatrixPosition(cube1); //first position in cube1 matrix
            var initPosCube2 = GetFirstCubeMatrixPosition(cube2); //first position in cube2 matrix

            //counter when is a match in all axis
            int volume = 0;

            for (var x = initPosCube2.X; x < cube2.SideSize + initPosCube2.X; x++)
            {
                for (var y = initPosCube2.Y; y < cube2.SideSize + initPosCube2.Y; y++)
                {
                    for (var z = initPosCube2.Z; z < cube2.SideSize + initPosCube2.Z; z++)
                    {
                        //if each axis are inside in the range of first position of first cube plus maxsize
                        if (x < (initPosCube1.X + cube1.SideSize) && y < (initPosCube1.Y + cube1.SideSize) && z < (initPosCube1.Z + cube1.SideSize))
                        {
                            volume++;
                        }
                    }
                }
            }

            return volume;
        }
   
        public bool HasCollision(Cube cube1, Cube cube2)
        {
            var initPosCube1 = GetFirstCubeMatrixPosition(cube1); //first position in cube1 matrix
            var initPosCube2 = GetFirstCubeMatrixPosition(cube2); //first position in cube2 matrix

            return (initPosCube1.X <= cube2.SideSize && cube1.SideSize >= initPosCube2.X) &&
                   (initPosCube1.Y <= cube2.SideSize && cube1.SideSize >= initPosCube2.Y) &&
                   (initPosCube1.Z <= cube2.SideSize && cube1.SideSize >= initPosCube2.Z);
        }

        public Point GetFirstCubeMatrixPosition(Cube cube)
        {
            var point = new Point();
            int halfSize = cube.SideSize / 2;

            point.X = cube.CenterPosition.X - halfSize;
            point.Y = cube.CenterPosition.Y - halfSize;
            point.Z = cube.CenterPosition.Z - halfSize;

            return point;
        }
    }
}
