
namespace Article02
{
    // Class này phải là public để XmlSerializer có thể truy cập
    public class InfoWindows
    {
        public int Width { get; set; }
        public int Height { get; set; }

        // Có thể mở rộng thêm Location X, Y nếu muốn lưu vị trí
        // public int X { get; set; }
        // public int Y { get; set; }
    }
}