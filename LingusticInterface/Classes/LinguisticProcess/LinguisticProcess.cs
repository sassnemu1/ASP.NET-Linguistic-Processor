using System;
using System.Collections.Generic;
using System.Linq;

namespace LingusticInterface
{
	public class LinguisticProcess
	{
		public List<string> wordListParseOfPredlog = new List<string>();
		public List<string> SymbolList = new List<string>();
		public List<string> PredlogList = new List<string>();

		static List<string> wordListNotSymbol = new List<string>();
		public void LinguisticProcessTextRender(string mainText)
		{
			CheckSymbol cheack = new CheckSymbol();
			Parsing pars = new Parsing();

			string[] MainTextArray = mainText.Split();

			//Удаление занаков препинания в тексте
			string lineNotSymbol = "";

			for (int i = 0; i < MainTextArray.Length; i++)
			{
				char[] wordArray = MainTextArray[i].ToCharArray();
				string wordNotSymbol = cheack.CheackSymbol(wordArray);

				lineNotSymbol = wordNotSymbol;
				wordListNotSymbol.Add(wordNotSymbol);
			}

			//Удаление предлогов в предложении
			string[] wordArrayNotSymbol = lineNotSymbol.Split();

			for (int i = 0; i < wordArrayNotSymbol.Length; i++)
			{
				string wordNotPredlog = pars.ParsingWordOfPredlog(wordArrayNotSymbol);
				wordListParseOfPredlog.Add(wordNotPredlog);
			}

		}
	}

	class Parsing : LinguisticProcess 
	{
		string[] predlogWordArray = { 
			"на", "под", "за", "к", "из", "по",
			"об", "от", "в", "у", "с", "о",
			"над", "около", "при", "перед",
		};
		public string ParsingWordOfPredlog(string[] wordArray) 
		{
			for (int i = 0; i < wordArray.Length; i++) 
			{
				for (int j = 0; j < predlogWordArray.Length; j++) 
				{
					if (wordArray[i] == predlogWordArray[j])
					{
						PredlogList.Add(predlogWordArray[j]);
						Array.Clear(wordArray, i, 1);
					}
				}
			}

			string resultWord = "";

			foreach (string s in wordArray)
			{
				resultWord += s;
				resultWord += " ";
			}
				
			return resultWord;
		}
	}
	class CheckSymbol : LinguisticProcess
	{
		List<string> wordListArray = new List<string>();

		char[] symbolArray = {
			',', '.', '/', ';', '\'', '\"', ':',
			'<', '>', '?', '`', '!', '@', '#',
			'$', '%', '^', '&', '*', '(', ')',
			'-', '_', '=', '+', '|', '~',
		};

		public string CheackSymbol(char[] wordArray)
		{
			for (int i = 0; i < wordArray.Length; i++)
			{
				for (int j = 0; j < symbolArray.Length; j++)
				{
					if (wordArray[i] == symbolArray[j])
					{
						Array.Clear(wordArray, i, 1);
					}	
				}
			}

			string wordString = new string(wordArray);
			wordListArray.Add(wordString);

			string word = "";

			foreach (string s in wordListArray)
			{
				word += s;
				word += " ";
			}

			return word;
		}
	}
}