using System;
using System.Linq;

namespace DesignPattern
{
	public class Testing
	{
        public string FindMostFrequentWord(string[] words)
        {
            string strResult = string.Empty;
            IDictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (!keyValuePairs.ContainsKey(word))
                {
                    keyValuePairs.Add(word, 1);
                }
                else
                {
                    int data;
                    keyValuePairs.TryGetValue(word,out data);
                    keyValuePairs[word] = data + 1;
                }
            }

            var d = keyValuePairs.MaxBy(a =>a.Value).Key;
            strResult = d.ToString();

            return strResult;

        }
    }
}

