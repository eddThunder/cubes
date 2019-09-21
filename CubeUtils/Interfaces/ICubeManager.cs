using CubeUtils.Models;

namespace CubeUtils.Interfaces
{
    public interface ICubeManager
    {
        float GetIntersectionVolume(Cube cube1, Cube cube2);
        Point GetFirstCubeMatrixPosition(Cube cube);
        bool HasCollision(Cube cube1, Cube cube2);
    }
}
