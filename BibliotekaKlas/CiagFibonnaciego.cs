namespace BibliotekaKlas
{
    class CiagFibonnaciego
    {

        public static void DodajInt(ref int n1, ref int n2, ref int result)
        {
            n1 = n2;
            n2 = result;
            result = n1 + n2;
        }
        public static void DodajString(ref string n1, ref string n2, ref string result)
        {
            n1 = n2;
            n2 = result;
            result = (int.Parse(n1) + int.Parse(n2)).ToString();
        }
    }
}
