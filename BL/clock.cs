using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task.BL
{
    internal class clock
    {
        public clock()
        {
        }
        public clock(int hours)
        {
            this.hours = hours;
        }
        public clock(int minutes, int hours)
        {
            this.minutes = minutes;
            this.hours = hours;
        }
        public clock(int second, int minutes, int hours)
        {
            this.seconds = second;
            this.minutes = minutes;
            this.hours = hours;
        }

        public int seconds;
        public int minutes;
        public int hours;

        public void incrementInSeconds()
        {
            seconds++;
        }
        public void incrementInMinutes()
        {
            minutes++;
        }
        public void incrementInHour()
        {
            hours++;
        }
        public void printObject()
        {
            Console.WriteLine(hours + " , " + minutes + " , " + seconds);
        }
        public bool manualTimingInput(int hours , int minutes , int seconds)
        {
            if(hours == this.hours && minutes == this.minutes && seconds == this.seconds)
            {
                return true;
            }
            return false;   
        }
        public bool objectTimingInput(clock temp)
        {
            if (hours == temp.hours && minutes == temp.minutes && seconds == temp.seconds)
            {
                return true;
            }
            return false ;
        }
    }
}
