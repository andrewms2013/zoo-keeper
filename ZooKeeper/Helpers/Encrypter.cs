﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace ZooKeeper.Helpers
{
    static class Encrypter
    {
        public static string GetMd5Hash(string input)
        {
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            
            StringBuilder sBuilder = new StringBuilder();
            
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            
            return sBuilder.ToString();
        }
    }
}
