using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCource.OOPBasics2
{
    public static class InterfaceHierarchy
    {
    }

    public interface IDrawable
    {
        void Draw();
    }

    public interface IAdvancedDraw : IDrawable
    {
        void DrawInBoundingBox(int top, int left, int bottom, int right);
        void DrawUpsideDown();
    }

    interface IPrintable
    {
        void Print();
        void Draw();
    }

    interface IShape : IDrawable, IPrintable
    {
        int GetNumberOfSides();
    }

    public class Bitmaplmage : IAdvancedDraw
    {
        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void DrawInBoundingBox(int top, int left, int bottom, int right)
        {
            throw new NotImplementedException();
        }

        public void DrawUpsideDown()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}