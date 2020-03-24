using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCource.OOPBasics2
{
    public static class ImplicitExplicit
    {
    }

    public interface IDrawToForm
    {
        void Draw();
    }

    public interface IDrawToMemory
    {
        void Draw();
    }

    public interface IDrawToPrinter
    {
        void Draw();
    }

    public class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        void IDrawToMemory.Draw()
        {
            throw new NotImplementedException();
        }

        void IDrawToPrinter.Draw()
        {
            throw new NotImplementedException();
        }

        void IDrawToForm.Draw()
        {
            throw new NotImplementedException();
        }
    }
}