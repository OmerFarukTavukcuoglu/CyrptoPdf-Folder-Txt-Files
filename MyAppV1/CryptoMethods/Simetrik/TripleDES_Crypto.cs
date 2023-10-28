using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyAppV1
{
    class TripleDES_Crypto
    {
        public string TripleDESSifrele(string strGiris)
        {
            string sonuc = "";
            if (strGiris == "" || strGiris == null)
            {
                throw new ArgumentNullException("veri yok.");
            }
            else
            {
                byte[] aryKey = System.Text.Encoding.UTF8.GetBytes("154875859854875154859658");
                byte[] aryIV = System.Text.Encoding.UTF8.GetBytes("15487596");
                TripleDESCryptoServiceProvider dec = new TripleDESCryptoServiceProvider();
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, dec.CreateEncryptor(aryKey, aryIV), CryptoStreamMode.Write);
                StreamWriter writer = new StreamWriter(cs);
                writer.Write(strGiris);
                writer.Flush();
                cs.FlushFinalBlock();
                writer.Flush();
                sonuc = Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
                writer.Dispose();             
                cs.Dispose();
                ms.Dispose();
            }
            return sonuc;
        }

        public string TripleDESCoz(string strGiris)
        {
            string strSonuc = "";
            if (strGiris == "" || strGiris == null)
            {
                throw new ArgumentNullException("veri yok.");
            }
            else
            {
                byte[] aryKey = System.Text.Encoding.UTF8.GetBytes("154875859854875154859658");
                byte[] aryIV = System.Text.Encoding.UTF8.GetBytes("15487596");
                TripleDESCryptoServiceProvider cryptoProvider = new TripleDESCryptoServiceProvider();
                MemoryStream ms = new MemoryStream(Convert.FromBase64String(strGiris));
                CryptoStream cs = new CryptoStream(ms, cryptoProvider.CreateDecryptor(aryKey, aryIV), CryptoStreamMode.Read);
                StreamReader reader = new StreamReader(cs);
                strSonuc = reader.ReadToEnd();
                reader.Dispose();
                cs.Dispose();
                ms.Dispose();
            }
            return strSonuc;
        }
    }
}
