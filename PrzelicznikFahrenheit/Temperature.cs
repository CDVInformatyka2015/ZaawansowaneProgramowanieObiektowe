namespace PrzelicznikFahrenheit
{
    class Temperature
    {
        double temp;

        private double FromStringParser(string temp)
        {
            return double.Parse(temp);
        }

        public double toCelsjusz(double f)
        {
            return (5.0 / 9.0) * (f - 32);
        }

        public double toFahrenheit(double c)
        {
            return (9.0 / 5.0) * c + 32;
        }

        public string toStringCelsjusz(string f)
        {
            temp = FromStringParser(f);
            return toCelsjusz(temp).ToString();
        }

        public string toStringFahrenheit(string c)
        {
            temp = FromStringParser(c);
            return toFahrenheit(temp).ToString();
        }
    }
}
