using CubeManager.Models;

namespace CubeManager.Interfaces
{
    public interface ICubeManager
    {
        int GetIntersectionVolume(Cube cube1, Cube cube2);
        Point GetFirstCubeMatrixPosition(Cube cube);

    }
}
