using System;

namespace DotNetCource.OOPBasics2
{
    public interface ISomeInterface
    {
        int Property { get; set; }
        string this[int index] { get; set; }

        void Run();
        //{
        //    Console.WriteLine("Method implementation");
        //}

        event EventHandler<int> ChangeEvent;
    }

    //System.Array, System.Data.SqlClient.SqlConnection, System.OperatingSystem, System.String 
    public interface ICloneable
    {
        object Clone();
    }
}