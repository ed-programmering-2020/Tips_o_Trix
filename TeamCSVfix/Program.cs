using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCSVfix {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Count cmd-line args: " + args.Length);
			foreach (string s in args){
				 
				Console.WriteLine(s);
						}
			if (args.Length < 1) return; 


			string sökväg = args[0]; // Filen ligger i mappen  \bin\Debug
			if (File.Exists(sökväg)) {
				StreamReader sr = new StreamReader(sökväg,Encoding.UTF8);
				string l = sr.ReadLine();
				string[] firstLine = l.Split(',');
				int cols = firstLine.Length ;

				sr.Close();
				sr = new StreamReader(sökväg);
				l = sr.ReadToEnd();
				l = replaceComma(l);
				//Console.WriteLine(l);
				string filename = sökväg.Substring(sökväg.LastIndexOf('.'));
				string path = sökväg.Substring(0,sökväg.LastIndexOf('.'));

				// to XLSX



				StreamWriter sw = new StreamWriter(path  + "_edit" + filename, false,Encoding.UTF8);
				sw.Write(replaceCommaBack(l));
				sw.Close();
				sr.Close();
			}			Console.WriteLine("finished converting ...");
				Console.ReadLine();
		}

		private static string replaceCommaBack(string v) {
			char[] bokstav = v.ToArray();
			int count = 0;
			for (int i = 0; i < bokstav.Length; i++) {

				if (bokstav[i] == ',') bokstav[i] = '\t';
				if (bokstav[i] == '¤' ) bokstav[i] = ',';
				if (bokstav[i] == '{') bokstav[i] = ' ';


			}
			return new string(bokstav);
		}



		private static string replaceComma(string v) {
			char[] bokstav = v.ToArray();
			int count = 0;
			for(int i = 0; i < bokstav.Length; i++){

				if (bokstav[i] == '"') { count++;  }
				if (bokstav[i] == ',' && count % 2 == 1) bokstav[i] = '¤';
				if (bokstav[i] == '\n' && count % 2 == 1)
				bokstav[i] = '{';
			}
			return new string(bokstav);
		}
	}
}
