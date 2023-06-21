namespace HT_20_06_Delagate
{
    internal class Program
    {
        public delegate double Converter(double EURO);

        static double EURO(double euro)
        {
            return euro * 12750.00;
        }

        static double USD(double usd) 
        {
            return usd * 11545.00;
        }

        static double RUB(double rub)
        {
            return rub * 150.00;
        }

        static double GBP(double gbp)
        {
            return gbp * 15100.00;
        }

        static double CHF(double chf)
        {
            return chf * 13250.00;
        }
        static void Main(string[] args)
        {

            Converter[] currencies = new Converter[5];
            currencies[0] = EURO;
            currencies[1] = USD;
            currencies[2] = RUB;
            currencies[3] = GBP;
            currencies[4] = CHF;

            foreach (var item in currencies)
            {
                Console.WriteLine($"100 {item.Method.Name} {item(100)} sum");
            }
        }
    }
    
}
