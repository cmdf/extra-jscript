namespace orez.jscript {
	class oParams {

		/// <summary>
		/// Optional. Tells whether the file is only to be compiled, not run.
		/// In such case, full path of the output binary should be output.
		/// </summary>
		public bool compile = false;
		/// <summary>
		/// Optional. Indicates the output path of the compiled script.
		/// </summary>
		public string output = null;
		/// <summary>
		/// Indicates the input script to be compiled.
		/// </summary>
		public string input;
		/// <summary>
		/// Input arguments to the script.
		/// </summary>
		public string args;
	}
}
