namespace Auto_anlassen_abdullaziz
{
    

    class Auto
    {
        public void Anlassen()
        {
            Console.WriteLine("Auto anlassen");
            Motor motor = new Motor();
            motor.Starten();
        }
    }

    class Motor
    {
        public void Starten()
        {
            Console.WriteLine("Motor gestartet");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Auto meinAuto = new Auto();
            meinAuto.Anlassen();

            Console.ReadLine();
        }
    }
}