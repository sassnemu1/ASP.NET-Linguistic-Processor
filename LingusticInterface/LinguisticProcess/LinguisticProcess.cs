using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LingusticInterface
{
	public class LinguisticProcess
	{
		public int countSymbol = 0;
		public List<string> wordList = new List<string>();

		public void LinguisticProcessTextRender(string text) 
		{
			CheckSymbol cheack = new CheckSymbol();

			string[] MainTextArray = text.Split();

			for (int i = 0; i < MainTextArray.Length; i++) 
			{
				char[] wordArray = MainTextArray[i].ToCharArray();
				string word = cheack.cheackSymbol(wordArray);
				wordList.Add(word);
			}
			
			
		}

	}

	class CheckSymbol : LinguisticProcess
	{
		List<string> wordListArray = new List<string>();

		static char[] symbolArray = {
			',', '.', '/', ';', '\'', '\"', ':',
			'<', '>', '?', '`', '!', '@', '#',
			'$', '%', '^', '&', '*', '(', ')',
			'-', '_', '=', '+', '|', '~',
		};

		public string cheackSymbol(char[] wordArray) {

			for (int i = 0; i < wordArray.Length; i++)
			{
				for (int j = 0; j < symbolArray.Length; j++)
				{
					if (wordArray[i] == symbolArray[j])
					{
						countSymbol++;
						Array.Clear(wordArray, i, 1);
					}
				}
			}

			string wordString = new string(wordArray);
			wordListArray.Add(wordString);

			string word = "";

			foreach (string s in wordListArray) 
				word += s;

			return word;
		}
	}

}