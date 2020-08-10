﻿namespace EDC.DesignPattern.Bridge
{
    /// <summary>
    ///     抽象图像类：抽象类
    /// </summary>
    public abstract class Image
    {
        protected ImageImplementor imageImpl;

        public void SetImageImplementor(ImageImplementor imageImpl)
        {
            this.imageImpl = imageImpl;
        }

        public abstract void ParstFile(string fileName);
    }
}