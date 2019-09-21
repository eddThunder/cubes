
using CubeUtils.Interfaces;
using CubeUtils.Models;

namespace CubeUtils
{
    public class CubeManager : ICubeManager
    {
        public CubeManager() { }

        public float GetIntersectionVolume(Cube cube1, Cube cube2)
        {
            var initPosCube1 = GetFirstCubeMatrixPosition(cube1); //first position in cube1 matrix
            var initPosCube2 = GetFirstCubeMatrixPosition(cube2); //first position in cube2 matrix

            float xSubstract = GetSubstractSpacesBetweenEdgesInAxis(initPosCube1.X, initPosCube2.X, cube1.SideSize, cube2.SideSize);
            float ySubstract = GetSubstractSpacesBetweenEdgesInAxis(initPosCube1.Y, initPosCube2.Y, cube1.SideSize, cube2.SideSize);
            float zSubstract = GetSubstractSpacesBetweenEdgesInAxis(initPosCube1.Z, initPosCube2.Z, cube1.SideSize, cube2.SideSize);

            return xSubstract * ySubstract * zSubstract;
        }

        /// <summary>
        /// Get the highest point value in any axis of one of both cubes and compare with the lowest point (same axis) from the other cube. 
        /// The the result is substracted by the sum of cube1 side size and cube 2 side size.
        /// </summary>
        /// <param name="axisValueCube1"></param>
        /// <param name="axisValueCube2"></param>
        /// <param name="cube1Width"></param>
        /// <param name="cube2Width"></param>
        /// <returns>float number</returns>
        public float GetSubstractSpacesBetweenEdgesInAxis(float axisValueCube1, float axisValueCube2, float cube1Width, float cube2Width)
        {
            float maxVal = (axisValueCube1 > axisValueCube2) ? axisValueCube1 + cube1Width : axisValueCube2 + cube2Width;
            float minVal = (axisValueCube1 < axisValueCube2) ? axisValueCube1 : axisValueCube2;

            float bothCubesSidesSum = cube1Width + cube2Width;

            return bothCubesSidesSum - (maxVal - minVal);
        }
       
        public bool HasCollision(Cube cube1, Cube cube2)
        {
            var initPosCube1 = GetFirstCubeMatrixPosition(cube1); //first position in cube1 matrix
            var initPosCube2 = GetFirstCubeMatrixPosition(cube2); //first position in cube2 matrix

            return (initPosCube1.X <= initPosCube2.X + cube2.SideSize && initPosCube1.X + cube1.SideSize >= initPosCube2.X) &&
                   (initPosCube1.Y <= initPosCube2.Y + cube2.SideSize && initPosCube1.Y + cube1.SideSize >= initPosCube2.Y) &&
                   (initPosCube1.Z <= initPosCube2.Z + cube2.SideSize && initPosCube1.Z + cube1.SideSize >= initPosCube2.Z);
        }

        public Point GetFirstCubeMatrixPosition(Cube cube)
        {
            var point = new Point();
            float halfSize = cube.SideSize / 2;

            point.X = cube.CenterPosition.X - halfSize;
            point.Y = cube.CenterPosition.Y - halfSize;
            point.Z = cube.CenterPosition.Z - halfSize;

            return point;
        }
    }
}
