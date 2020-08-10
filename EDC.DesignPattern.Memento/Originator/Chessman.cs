namespace EDC.DesignPattern.Memento
{
    /// <summary>
    ///     原发器：Chessman
    /// </summary>
    public class Chessman
    {
        public Chessman(string label, int x, int y)
        {
            Label = label;
            X = x;
            Y = y;
        }

        public string Label { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        // 保存状态
        public ChessmanMemento Save()
        {
            return new ChessmanMemento(Label, X, Y);
        }

        // 恢复状态
        public void Restore(ChessmanMemento memento)
        {
            Label = memento.Label;
            X = memento.X;
            Y = memento.Y;
        }
    }
}