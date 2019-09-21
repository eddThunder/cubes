using CubeUtils.Models;

namespace CubeUtils.Test.Builders
{
    public class PointBuilder
    {
        private Point point;

        public PointBuilder()
        {
            point = new Point();
        }

        public PointBuilder WithX(float x)
        {
            point.X = x;
            return this;
        }

        public PointBuilder WithY(float y)
        {
            point.Y = y;
            return this;
        }

        public PointBuilder WithZ(float z)
        {
            point.Z = z;
            return this;
        }

        public Point Build()
        {
            return point;
        }
    }
}
