using System;
using System.IO;

namespace orez.jscript {
	class Program {
		static void Main(string[] args) {
			var jsc = GetJscPath();
			var jtmp = evar("temp") + "\\0rez\\cs-jscript";

		}

		/// <summary>
		/// Get Jscript.NET Compiler path.
		/// </summary>
		/// <returns>Full path of the compiler.</returns>
		private static string GetJscPath() {
			// check env var
			var jsc = Environment.GetEnvironmentVariable("JSC_PATH");
			if(jsc == null) {
				// prepare
				var jptn = "*jsc.exe";
				var jpth = evar("systemroot") + "\\microsoft.net\\framework\\";
				// srch jscript.net cmplr
				foreach(var a in Directory.GetFiles(jpth, jptn, SearchOption.AllDirectories))
					jsc = a;
				// add env var
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
