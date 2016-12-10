namespace PrzelicznikFahrenheit
{
    class Temperature
    {
        double temp;

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
            temp = double.Parse(f);
            return toCelsjusz(temp).ToString();
        }

        public string toStringFahrenheit(string c)
        {
            temp = double.Parse(c);
            return toFahrenheit(temp).ToString();
        }
    }
}
