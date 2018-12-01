using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Disk
    {
        private int speed;
        private int capacity;
        private int volume;

        public string Typ { get; set; }

        public string Country { get; set; }

        public string Sata { get; set; }
                
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > 0)
                    speed = value;
                else
                    throw new InvalidSpeedException();
            }
        }

        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (value > 0)
                    capacity = value;
                else
                    throw new InvalidCapacityException();
            }
        }

        public int Volume
        {
            get { return volume; }
            set
            {
                if (value > 0)
                    volume = value;
                else
                    throw new InvalidVolumeException();
            }
        }

        public override string ToString()
        {
            return string.Format(
                "Тип: {0}\n" +
                "Країна: {1}\n" +
                "Швидкість: {2}\n" +
                "Ємність: {3}\n" +
                "Об'єм буферу: {4}\n" +
                "Інтерфейс: {5} кг\n",Typ, Country, Speed, Capacity, Volume, Sata );
        }
    }

    public class DiskException : Exception
    {
        public DiskException(string messange) : base(messange) { }
    }

    public class InvalidSpeedException : DiskException
    {
        public InvalidSpeedException() : base("Invalid speed input") { }
    }

    public class InvalidCapacityException : DiskException
    {
        public InvalidCapacityException() : base("Invalid capacity input") { }
    }

    public class InvalidVolumeException : DiskException
    {
        public InvalidVolumeException() : base("Invalid volume input") { }
    }
}
