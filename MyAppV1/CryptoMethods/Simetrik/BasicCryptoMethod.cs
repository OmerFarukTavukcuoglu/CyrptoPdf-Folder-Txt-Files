using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppV1
{
    class BasicCryptoMethod
    {
        public string BasicEnCryp(string text)
        {

            string sifrelenmis = "";
            if (text == "")
                throw new ArgumentNullException("Şifrelenecek veri yok");


            foreach (char harf in text)
            {
                sifrelenmis += Convert.ToChar(harf + 3);
            }
            return sifrelenmis;
        }

        public string BasicDeCryp(string text)
        {
            string sifrelimetin = "";
            if (text == "")

                throw new ArgumentNullException("Şifrelenecek veri yok");


            foreach (char harf in text)
            {
                sifrelimetin += Convert.ToChar(harf - 3);
            }
            return sifrelimetin;
        }
    }
}
