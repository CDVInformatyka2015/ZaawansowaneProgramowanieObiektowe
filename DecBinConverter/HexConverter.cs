using System;

namespace DecBinConverter
{
    class HexConverter
    {
        public string DecToBin(string dec)
        {
            try
            {
                return Convert.ToString(int.Parse(dec), 2);
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string BinToDec(string bin)
        {
            try
            {
                return Convert.ToInt32(bin, 2).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
    }
}
