using System.Collections.Generic;

namespace EDC.DesignPattern.Memento
{
    /// <summary>
    ///     负责人：MementoCaretaker
    /// </summary>
    public class NewMementoCaretaker
    {
        private readonly IList<ChessmanMemento> mementoList = new List<ChessmanMemento>();

        public ChessmanMemento GetMemento(int i)
        {
            return mementoList[i];
        }

        public void SetMemento(ChessmanMemento memento)
        {
            mementoList.Add(memento);
        }
    }
}