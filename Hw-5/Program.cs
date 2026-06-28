namespace Hw_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store1 = new Store("АТБ", "Київ", "Продукти", "0501234567", "atb@gmail.com", 120);
            Store store2 = new Store("Сільпо", "Львів", "Супермаркет", "0677654321", "silpo@gmail.com", 150);

            Console.WriteLine("Перший магазин:");
            Console.WriteLine(store1);

            Console.WriteLine("\nДругий магазин:");
            Console.WriteLine(store2);

            store1 = store1 + 30;
            Console.WriteLine("\nПісля збільшення площі першого магазину:");
            Console.WriteLine(store1);

            store2 = store2 - 20;
            Console.WriteLine("\nПісля зменшення площі другого магазину:");
            Console.WriteLine(store2);

            Console.WriteLine("\nПорівняння:");

            Console.WriteLine("store1 == store2 : " + (store1 == store2));
            Console.WriteLine("store1 != store2 : " + (store1 != store2));
            Console.WriteLine("store1 > store2  : " + (store1 > store2));
            Console.WriteLine("store1 < store2  : " + (store1 < store2));
        }
    }

    class Store
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Profile { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double Area { get; set; }

        public Store(string name, string address, string profile,
                     string phone, string email, double area)
        {
            Name = name;
            Address = address;
            Profile = profile;
            Phone = phone;
            Email = email;
            Area = area;
        }

        public override string ToString()
        {
            return $"Назва: {Name}\n" +
                   $"Адреса: {Address}\n" +
                   $"Профіль: {Profile}\n" +
                   $"Телефон: {Phone}\n" +
                   $"Email: {Email}\n" +
                   $"Площа: {Area} м²";
        }

        public static Store operator +(Store s, double value)
        {
            s.Area += value;
            return s;
        }

        public static Store operator -(Store s, double value)
        {
            s.Area -= value;
            return s;
        }

        public static bool operator ==(Store a, Store b)
        {
            return a.Area == b.Area;
        }

        public static bool operator !=(Store a, Store b)
        {
            return a.Area != b.Area;
        }

        public static bool operator >(Store a, Store b)
        {
            return a.Area > b.Area;
        }

        public static bool operator <(Store a, Store b)
        {
            return a.Area < b.Area;
        }

        public override bool Equals(object obj)
        {
            if (obj is Store other)
                return Area == other.Area;

            return false;
        }

        public override int GetHashCode()
        {
            return Area.GetHashCode();
        }
    }
}