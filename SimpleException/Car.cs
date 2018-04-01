using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleException
{
    class Car
    {
        public const int maxSpeed = 100;
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }
        private bool carIsDead;
        private Radio theMusicBox = new Radio();
        public Car (string name, int speed)
        {
            PetName = name;
            CurrentSpeed = speed;
        }
        public Car()
        { }
        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }
        public void Accelerate(int delta)
        {
            if (carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > maxSpeed)
                {
                    CurrentSpeed = 0;
                    carIsDead = true;
                    throw new Exception(string.Format("{0} has overheated.", PetName));
                }
                else
                    Console.WriteLine("Current speed is: {0}", CurrentSpeed);
            }
        }
    }
}
