using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCource.OOPBasics2
{
    public static class CloneablesComparables
    {
        public static void Run()
        {
            var garage = new CloneableGarage();
            var clone = (CloneableGarage)garage.Clone();
            garage.Primitive = 10;
            Array.Sort(clone.Cars);
        }
    }

    public class CloneableGarage : ICloneable
    {
        public int Primitive;
        public CloneableCar[] Cars =
        {
            new CloneableCar("Car2"),
            new CloneableCar("Car1")
        };

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    public class CloneableCar
    {
        public CloneableCar(string name)
        {
            Name = name;
        }

        public string Name { get; }

        //public int CompareTo(object obj)
        //{
        //    if (obj == null)
        //        throw new ArgumentNullException(nameof(obj));

        //    var car = obj as CloneableCar;
        //    if (car == null)
        //        throw new InvalidOperationException();

        //    return Name.CompareTo(car.Name);
        //}
    }

    //public interface IComparable
    //{
    //    int CompareTo(object o);
    //}
}
