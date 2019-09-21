

namespace CubeManager.Models
{
    public class Cube
    {
        public int SideSize { get; set; }

        public Point CenterPosition { get; set; }

        public Cube()
        {
            CenterPosition = new Point();
        }
    }
}
