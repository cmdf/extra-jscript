using System;
using System.IO;

namespace orez.jscript {
	class Program {
		static void Main(string[] args) {
			// prepare
			var jpth = Environment.GetEnvironmentVariable("systemroot")+"\\microsoft.net\\framework\\";
			var jtmp = 
			// search jscript.net compiler
			var JSC_PATH = Environment.GetEnvironmentVariable("JSC_PATH");
			if(JSC_PATH == null) {
				foreach(var a in Directory.GetFiles()
			}
		}

		// shortcut for get environment variable
		private static string evar(string name) {
			return Environment.GetEnvironmentVariable(name);
		}
	}
}
