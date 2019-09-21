

namespace CubeUtils.Models
{
    public class Cube
    {
        public float SideSize { get; set; }

        public Point CenterPosition { get; set; }

        public Cube()
        {
            CenterPosition = new Point();
        }
    }
}
