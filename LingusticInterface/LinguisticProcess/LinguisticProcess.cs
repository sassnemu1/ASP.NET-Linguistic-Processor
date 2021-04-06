using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LingusticInterface
{
	public class LinguisticProcess
	{
		static List<string> wordListNotSymbol = new List<string>();
		public List<string> wordListParseOfPredlog = new List<string>();
		public void LinguisticProcessTextRender(string text) 
		{
			CheckSymbol cheack = new CheckSymbol();
			Parsing pars = new Parsing();

			string[] MainTextArray = text.Split();

			//Удаление занаков препинания в тексте
			string lineNotSymbol = "";

			for (int i = 0; i < MainTextArray.Length; i++) 
			{
				char[] wordArray = MainTextArray[i].ToCharArray();
				string wordNotSymbol = cheack.cheackSymbol(wordArray);

				lineNotSymbol = wordNotSymbol;
				wordListNotSymbol.Add(wordNotSymbol);
			}

			string[] wordArrayNotSymbol = lineNotSymbol.Split();

			for (int i = 0; i < wordArrayNotSymbol.Length; i++) 
			{
				string wordNotPredlog = pars.parsingWordOfPredlog(wordArrayNotSymbol);
				wordListParseOfPredlog.Add(wordNotPredlog);
			}
			
		}
	}

	class Parsing : LinguisticProcess 
	{
		string[] predlogWordArray = { 
			" ", "на", "под", "за", "к", "из", "по",
			"об", "от", "в", "у", "с", "о",
			"над", "около", "при", "перед",
		};
		public string parsingWordOfPredlog(string[] wordArray) 
		{
			for (int i = 0; i < wordArray.Length; i++) 
			{
				for (int j = 0; j < predlogWordArray.Length; j++) 
				{
					if (wordArray[i] == predlogWordArray[j]) 
					{
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
	//-------------------------------------------------------
	class CheckSymbol : LinguisticProcess
	{
		List<string> wordListArray = new List<string>();

		static char[] symbolArray = {
			',', '.', '/', ';', '\'', '\"', ':',
			'<', '>', '?', '`', '!', '@', '#',
			'$', '%', '^', '&', '*', '(', ')',
			'-', '_', '=', '+', '|', '~',
		};

		public string cheackSymbol(char[] wordArray)
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