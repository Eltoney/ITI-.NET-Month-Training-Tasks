using System;

namespace Water_Pool
{

    class Heater
    {
        public float heaterTemp
        {
            set; get;
        }

        public void heatThePool(float newTemp)
        {
            if (heaterTemp > newTemp)
            {
                System.Console.WriteLine("Heater On");
            }
            else
            {
                System.Console.WriteLine("Heater Off");
            }
        }
    }

    class Cooler
    {
        public float coolerTemp
        {
            set; get;
        }

        public void coolThePool(float newTemp)
        {
            if (coolerTemp < newTemp)
            {
                System.Console.WriteLine("Cooler On");
            }
            else
            {
                System.Console.WriteLine("Cooler Off");
            }
        }
    }

    class Thermometer
    {
        int curTemp;
        public int CurTemp
        {
            set
            {
                if (curTemp != value)
                {
                    curTemp = value;
                    if (onTempChange != null)
                    {
                        onTempChange(curTemp);
                    }
                }
            }
            get
            {
                return curTemp;
            }
        }

        public event Action<float> onTempChange;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thermometer temp = new Thermometer() { CurTemp = 50 };
            Heater h = new Heater() { heaterTemp = 30 };
            Cooler c = new Cooler() { coolerTemp = 60 };
            temp.onTempChange += h.heatThePool;
            temp.onTempChange += c.coolThePool;


            temp.CurTemp = 40;
            System.Console.WriteLine("=========================");
            temp.CurTemp = 100;
            System.Console.WriteLine("=========================");
            temp.CurTemp = 10;



        }
    }
}
