using System;
using System.IO;

namespace orez.jscript {
	class Program {
		static void Main(string[] args) {
			// prepare

		}

		// get jscript.net compiler
		private static string GetJscPath() {
			// prepare
			var jpth = evar("systemroot") + "\\microsoft.net\\framework\\";
			var jtmp = evar("temp") + "\\0rez\\cs-jscript";
			var jptn = "*jsc.exe";
			// search jscript.net compiler
			var jsc = Environment.GetEnvironmentVariable("JSC_PATH");
			if(jsc == null) {
				foreach(var a in Directory.GetFiles(jpth, jptn, SearchOption.AllDirectories))
					jsc = a;
				evar("JSC_PATH", jsc);
			}
			return jsc;
		}

		// shortcut to get environment variable
		private static string evar(string name) {
			return Environment.GetEnvironmentVariable(name);
		}

		// shortcut to set environment variable
		private static void evar(string name, string value) {
			Environment.SetEnvironmentVariable(name, value);
		}
	}
}
