using System;
using System.IO;

namespace ComputeHashSelectFileLib
{
	public class CustomFileInfo
	{
		private string _filePath;

		public CustomFileInfo (string path)
		{
			this._filePath = path;
		}

		public string path {
			get {
				return this._filePath;
			}
		}

		public string fileName {
			get {
				return File.Exists(_filePath) ? Path.GetFileName (this.path) : @"FILE NOT FOUND";
			}
		}

		public string lastWriteTime {
			get {
				return File.Exists(_filePath) ? File.GetLastWriteTime (this.path).ToString() : @"FILE NOT FOUND";
			}
		}
	
		public string hashOfFileContent {
			get {
				return File.Exists(_filePath) ? ComputeHash.getHashWithFile (this.path): @"FILE NOT FOUND";
			}
		}
	}
}

