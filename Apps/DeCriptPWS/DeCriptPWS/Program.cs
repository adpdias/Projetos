using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeCriptPWS
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = DeCriptPWS("0000004D0000001C000000520000002200000049000000260000004800000026000000460000002D0000003B");
            //Console.WriteLine(text);
            //Console.ReadKey();
        }


        //public static string DeCriptPWS(string content)
        //{
        //    const int period = 30;
        //    int CodCriptChar;
        //    int CodChar;
        //    int displacement;
        //    char[] contentAux1 = new char[content.Length];
        //    string contentAux2;



        //    displacement = period;
        //    var contentAux = HexToChar(content);

        //    for (int i = 1; i < contentAux.Length; i++)
        //    {
        //        CodCriptChar = (int)contentAux[i];
        //        if ((i % 2) == 0)
        //        {
        //            CodChar = CodCriptChar + displacement - (i % period);
        //        }
        //        else
        //        {
        //            CodChar = CodCriptChar - displacement + (i % period);
        //        }
        //        (char)CodChar;

        //        displacement = displacement - 1;
        //        if (displacement == 0)
        //        {
        //            displacement = period;
        //        }
        //    }

        //    return contentAux2;
        //}

        //private static string HexToChar(string text)
        //{
        //    string str = "";
        //    for (int i = 0; i < text.Length; i += 4)
        //    {
        //        str += (char)Int64.Parse(text.Substring(i, 4), System.Globalization.NumberStyles.AllowHexSpecifier);
        //    }
        //    return str;
        //}

    }
}
