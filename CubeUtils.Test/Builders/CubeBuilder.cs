using CubeUtils.Models;

namespace CubeUtils.Test.Builders
{
    public class CubeBuilder
    {
        private Cube cube;

        public CubeBuilder()
        {
            cube = new Cube();
            cube.CenterPosition = new Point();
        }

        public CubeBuilder WithSize(float size)
        {
            cube.SideSize = size;
            return this;
        }

        public CubeBuilder WithCenterX(float x)
        {
            cube.CenterPosition.X = x;
            return this;
        }

        public CubeBuilder WithCenterY(float y)
        {
            cube.CenterPosition.Y = y;
            return this;
        }

        public CubeBuilder WithCenterZ(float z)
        {
            cube.CenterPosition.Z = z;
            return this;
        }

        public Cube Build()
        {
            return cube;
        }

       
    }
}
