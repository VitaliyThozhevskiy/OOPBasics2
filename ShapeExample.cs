using System;

namespace DotNetCource.OOPBasics2
{
    public abstract class Shape
    {
        public abstract void Draw();
        public abstract byte GetNumberOfPoints();
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            throw new System.NotImplementedException();
        }

        public override byte GetNumberOfPoints() => 4;
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            throw new System.NotImplementedException();
        }

        public override byte GetNumberOfPoints() => 0;
    }

    #region Solving
    public abstract class Shape1
    {
        public abstract void Draw();
    }
    public interface IPointy
    {
        byte GetNumberOfPoints();
    }

    public class Rectangle1 : Shape1, IPointy
    {
        public override void Draw()
        {
            throw new System.NotImplementedException();
        }

        public byte GetNumberOfPoints() => 4;
    }

    public class Circle1 : Shape1
    {
        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
    #endregion

    #region 3D
    public interface IDraw3D
    {
        void Draw3D();
    }
    #endregion
}
