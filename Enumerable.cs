using System;
using System.Collections;
using System.Text;

namespace DotNetCource.OOPBasics2
{
    public static class Enumerable
    {
        //say about yield return
        public static void Run()
        {
            var g = new Garage();
            foreach (var car in g)
                car.ToString();
        }
    }

    public class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];

        public IEnumerator GetEnumerator()
        {
            return carArray.GetEnumerator();
        }
    }
}
