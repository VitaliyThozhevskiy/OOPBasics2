using System;
using System.IO;
using System.Runtime.Serialization;

namespace DotNetCource.OOPBasics2
{
    public static class SimpleExceptionExample
    {
        public static void Run()
        {
            Console.WriteLine("*****Simple Exception Example * ****");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);

            myCar.CrankTunes(true);

            for (int i = 0; i < 10; i++)
                myCar.Accelerate(10);

            Console.ReadLine();
        }

        public static void RunSafety()
        {
            try
            {
                Run();
            }
            //catch (CarIsDeadException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.ErrorTimeStamp);
            //    Console.WriteLine(e.CauseOfError);
            //    //throw;
            //}
            catch (CarIsDeadException ex)
            {
               FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
               throw;
            }
            catch (OutOfMemoryException exception)
            {
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error' ***");
                Console.WriteLine("Method: {0}", e.TargetSite);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Stack: {0}", e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Almost always executing!");
            }

            Console.WriteLine("\n***** Out of exception logic *****");
            Console.ReadLine();
        }
    }

    class Radio
    {
        public void TurnOn(bool on)
        {
            Console.WriteLine(on ? "Jamming..." : "Quiet time...");
        }
    }

    class Car
    {
        public const int MaxSpeed = 100;
        private bool carlsDead;
        private Radio theMusicBox = new Radio();

        public Car()
        {
        }

        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if (carlsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
                CurrentSpeed += delta;

            if (CurrentSpeed > MaxSpeed)
            {
                //throw new CarEx();
                //throw new CarIsDeadException($"{PetName} has overheated!", "You have a lead foot", DateTime.Now); 
                Console.WriteLine("{0} has overheated!", PetName);
                CurrentSpeed = 0;
                carlsDead = true;
            }
            else
            {
                Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
    public class CarEx : CarIsDeadException
    {

    }
    public class CarIsDeadException : Exception
    {
        private string _messageDetails = "";

        public CarIsDeadException() 
        {
        }

        public CarIsDeadException(string message, string cause, DateTime time)
            : base(message)
        {
            _messageDetails = message;
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

        public DateTime ErrorTimeStamp { get; }
        public string CauseOfError { get; }

        public override string Message => $"Car Error Message: {_messageDetails}";
    }

    public class CarIsDeadException1 : ApplicationException, ISerializable
    {
        public CarIsDeadException1()
        {
        }

        public CarIsDeadException1(string message)
            : base(message) 
        { 
        }

        public CarIsDeadException1(string message, Exception inner)
            : base(message, inner)
        { 
        }

        protected CarIsDeadException1(SerializationInfo info, StreamingContext context)
            : base(info, context) 
        { 
        }
    }
}