

namespace Article01
{
    // Phải là public để XML Serializer truy cập được
    public class InfoWindows
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public InfoWindows() { }
    }
}