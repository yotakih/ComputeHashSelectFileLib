using System;
using System.IO;
using System.Security.Cryptography;

namespace ComputeHashSelectFileLib
{
	public class ComputeHash
	{
		private static MD5CryptoServiceProvider md5Provider = new MD5CryptoServiceProvider();

		private ComputeHash ()
		{
		}

		public static string getHashWithFile(string path)
		{
			using (var fs = new FileStream (path, FileMode.Open)) {
				byte[] b = md5Provider.ComputeHash (fs);
				return BitConverter.ToString (b).ToLower().Replace (@"-", @"");
			}
		}
	}
}

