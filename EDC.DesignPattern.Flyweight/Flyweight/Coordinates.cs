namespace EDC.DesignPattern.Flyweight
{
    /// <summary>
    ///     外部状态：棋子坐标
    /// </summary>
    public class Coordinates
    {
        public Coordinates()
        {
        }

        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}