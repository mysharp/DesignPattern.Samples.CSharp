namespace EDC.DesignPattern.Composite.RefactoredVersion
{
    /// <summary>
    ///     抽象文件类：抽象构件
    /// </summary>
    public abstract class AbstractFile
    {
        public abstract void Add(AbstractFile file);
        public abstract void Remove(AbstractFile file);
        public abstract AbstractFile GetChild(int index);
        public abstract void KillVirus();
    }
}