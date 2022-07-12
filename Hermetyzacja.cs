using System;
using System.Threading;

namespace Consoleapp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // PROGRAMOWANIE OBIEKTOWE: Hermetyzacja (Enkapsulacja)

            // Znaczenie w sieciach komputerowych:

            // Enkapsulacja (dekapsulacja) danych jest procesem zachodzącym
            // w kolejnych warstwach modelu ISO / OSI.

            // Proces enkapsulacji oznacza dokładanie dodatkowej informacji (nagłówka)
            // związanej z działającym protokołem danej warstwy i przekazywaniu tej
            // informacji warstwie niższej do kolejnego procesu enkapsulacji.

            // Proces dekapsulacji polega na zdejmowaniu dodatkowej
            // informacji w kolejnych warstwach modelu ISO/ OSI.








            // W programowaniu hermetyzacja polega na ukrywaniu pewnych danych składowych
            // lub metod obiektów danej klasy tak, aby były one dostępne tylko metodom
            // wewnętrznym danej klasy lub funkcjom zaprzyjaźnionym.

            // Modyfikatory dostępu dostępne w C#:

            // public: Dostęp nie jest ograniczony.

            // protected: Dostęp jest ograniczony do zawierającej klasy lub typów
            // pochodzących z klasy zawierającej.

            // internal: Dostęp jest ograniczony do bieżącego zestawu.

            // protected internal: Dostęp jest ograniczony do bieżącego zestawu
            // lub pochodzących z zawierającej klasy.

            // private: Dostęp jest ograniczony do typu zawierającego.

            // private protected: Dostęp jest ograniczony do zawierającej klasy lub typów
            // pochodzących z klasy zawierającej w bieżącym zestawie.






            Car car = new Car("BMW");
            car.Cost = 8000;
            car.Description = "Niezawodny i szybki samochód!";
            
            car.Ride(10001);

            car.Stop();

            //car.ImmediateStop(); - BŁĄD

            Console.WriteLine("Koniec gry!");

            //Console.WriteLine(car.Cost);
            //Console.WriteLine(car.Description);

        }
    }

    public class Car
    {
        private string _brand;

        public int Cost { get; set; }
        public string Description { get; set; }

        public Car(string brand)
        {
            _brand = brand;
        }

        public void Ride(int time)
        {
            Console.WriteLine($"Samochód marki {_brand} w trasie!" +
                "\nPrzejażdzka będzie trwała " + time / 1000 + " sekund.");

            if (time > 10000)
            {   
                Thread.Sleep(1000);
                ImmediateStop();
            }
            else
                Thread.Sleep(time);
        }

        public void Stop()
        {
            Console.WriteLine("Samochód się zatrzymał!");
        }

        private void ImmediateStop()
        {
            Console.WriteLine("Samochód został natychmiastowo zatrzymany!");
        }
    }
}
