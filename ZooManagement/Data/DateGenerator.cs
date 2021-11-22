using System;

namespace ZooManagement.Data
{
    public class DateGenerator
    {
        private static Random _random = new Random();
        private static DateTime _start = new DateTime(1995, 1, 1);
        
        public static DateTime GetAnimalDateOfBirth()
        {
            int range = (DateTime.Today - _start).Days;
            return _start.AddDays(_random.Next(range));
        }

        public static DateTime GetAnimalDateAcquired()
        {
            var randomDaysToAdd = _random.Next(1, 5000);
            return _start.AddDays(randomDaysToAdd);
        }
    }
}