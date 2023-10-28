using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyAppV1
{
    class RSA_Crypto
    {
        public string RSASifrele(string strGiris, out RSAParameters prm)
        {
            string strSonuc = "";
            if (strGiris == "")
            {
                throw new ArgumentNullException("veri yok.");
            }
            else
            {
                byte[] aryDizi = System.Text.Encoding.UTF8.GetBytes(strGiris);
                RSACryptoServiceProvider dec = new RSACryptoServiceProvider();
                prm = dec.ExportParameters(true);
                byte[] aryDonus = dec.Encrypt(aryDizi, false);
                strSonuc = Convert.ToBase64String(aryDonus);
            }
            return strSonuc;
        }

        public string Coz(string strGiris, RSAParameters prm)
        {
            string strSonuc = "";
            if (strGiris == "" || strGiris == null)
            {
                throw new ArgumentNullException("veri yok");
            }
            else
            {
                RSACryptoServiceProvider dec = new RSACryptoServiceProvider();
                byte[] aryDizi = Convert.FromBase64String(strGiris);
                UnicodeEncoding UE = new UnicodeEncoding();
                dec.ImportParameters(prm);
                byte[] aryDonus = dec.Decrypt(aryDizi, false);
                strSonuc = UE.GetString(aryDonus);
            }
            return strSonuc;
        }
    }
}
