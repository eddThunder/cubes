using CubeUtils.Models;

namespace CubeUtils.Interfaces
{
    public interface ICubeManager
    {
        float GetIntersectionVolume(Cube cube1, Cube cube2);
        bool HasCollision(Cube cube1, Cube cube2);
        float GetSubstractSpacesBetweenEdgesInAxis(float axisValueCube1, float axisValueCube2, float cube1Width, float cube2Width);
        Point GetFirstCubeMatrixPosition(Cube cube);
    }
}
