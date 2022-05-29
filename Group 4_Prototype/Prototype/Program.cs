using System;

namespace Prototype
{
    public abstract class Phone
    {
        protected int basePrice = 0, onRoadPrice = 0;
        public string ModelName { get; set; }
        public int BasePrice
        {
            set => basePrice = value;
            get => basePrice;
        }
        public int OnRoadPrice
        {
            set => onRoadPrice = value;
            get => onRoadPrice;
        }
        public static int SetAdditionalPrice()
        {
            Random random = new Random();
            int additionalPrice = random.Next(200_000, 500_000);
            return additionalPrice;
        }
        public abstract Phone Clone();

    }
    public class Iphone : Phone
    {
        public Iphone(string model) => (ModelName, BasePrice) = (model, 400_000);
        public override Phone Clone() => this.MemberwiseClone() as Iphone;

    }
    public class SamSung : Phone
    {
        public SamSung(string model) => (ModelName, BasePrice) = (model, 250_000);
        public override Phone Clone() => this.MemberwiseClone() as SamSung;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Prototype Pattern Demo***\n");
            Phone iphone = new Iphone("Iphone 13 Pro Max");
            Phone samsung = new SamSung("SamSung Galaxy S22 Ultra");

            Console.WriteLine($"Phone is: {iphone.ModelName}, and it's base price is Rs. {iphone.BasePrice}");
            Console.WriteLine($"Phone is: {samsung.ModelName}, and it's base price is Rs. {samsung.BasePrice}");
            Phone Phone;
            Phone = iphone.Clone();
            Phone.OnRoadPrice = Phone.BasePrice + Phone.SetAdditionalPrice();
            Console.WriteLine($"Phone is: {Phone.ModelName}, and it's price is Rs. {Phone.OnRoadPrice}");
            Phone = samsung.Clone();
            Phone.OnRoadPrice = Phone.BasePrice + Phone.SetAdditionalPrice();
            Console.WriteLine($"Phone is: {Phone.ModelName}, and it's price is Rs. {Phone.OnRoadPrice}");
            Console.ReadLine();
        }
    }
}
