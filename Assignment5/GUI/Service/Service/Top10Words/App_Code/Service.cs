using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    //Required service 1: Top10Words 
    public string[] Top10Words(string url)
    {
        Web2StringService.ServiceClient proxy = new Web2StringService.ServiceClient();
        string originalStr = proxy.GetWebContent(url);//GetWebContent(url);
        string atStr = @originalStr;
        string oldStr = @"[^a-zA-Z]"; //Define word: only consist of alphabetical characters (a-z, A-Z)
        string dataStr = Regex.Replace(atStr, oldStr, " ").ToLower();

        //       string dataStr = System.Text.Encoding.Default.GetString(data);
        //Console.WriteLine(dataStr);

        ArrayList wordList = new ArrayList();
        Hashtable hash = new Hashtable();
        int value, count = 0;
        foreach (string s in dataStr.Split())
        {
            if (s.Trim().Length != 0)
            {
                //    System.Console.Write("[{0}]", s);
                wordList.Add(s);
                if (hash.Contains(s) == false)
                {
                    hash.Add(s, 1);
                    count++;
                }
                else
                {
                    value = Convert.ToInt32(hash[s]);
                    value++;
                    hash[s] = value;
                }
            }
        }
        //Console.WriteLine("Original hash:");
        //foreach (DictionaryEntry entry in hash)
        //{
        //    Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
        //}


        ArrayList hashList = new ArrayList();
        foreach (DictionaryEntry entry in hash)
        {
            hashPair pair = new hashPair(entry.Key.ToString(), Convert.ToInt32(entry.Value));
            hashList.Add(pair);
        }

        //Console.WriteLine("Sorted hash:");
        quickSort(hashList, 0, hashList.Count - 1);

        string[] topList = new string[10];
        for (int i = hashList.Count - 1, j = 0; i >= 0 && j < 10; i--, j++)
        {
            //Console.WriteLine("{0}: {1}", ((hashPair)hashList[i]).getKey(), ((hashPair)hashList[i]).getValue());
            topList[j] = String.Copy(((hashPair)hashList[hashList.Count - 1 - j]).getKey());
        }
        return topList;
    }

    private static int partition(ArrayList hashList, int start, int end)
    {
        int i = start - 1;
        int j = start;
        hashPair temp;
        for (; j < end; j++)
        {
            if ((((hashPair)hashList[j]).getValue() < ((hashPair)hashList[end]).getValue()))
            {
                i++;
                temp = new hashPair(((hashPair)hashList[j]).getKey(), ((hashPair)hashList[j]).getValue());
                ((hashPair)hashList[j]).setKey(((hashPair)hashList[i]).getKey());
                ((hashPair)hashList[j]).setValue(((hashPair)hashList[i]).getValue());
                ((hashPair)hashList[i]).setKey(temp.getKey());
                ((hashPair)hashList[i]).setValue(temp.getValue());
            }
        }
        i++;
        temp = new hashPair(((hashPair)hashList[end]).getKey(), ((hashPair)hashList[end]).getValue());
        ((hashPair)hashList[end]).setKey(((hashPair)hashList[i]).getKey());
        ((hashPair)hashList[end]).setValue(((hashPair)hashList[i]).getValue());
        ((hashPair)hashList[i]).setKey(temp.getKey());
        ((hashPair)hashList[i]).setValue(temp.getValue());
        return i;
    }

    private static void quickSort(ArrayList hashList, int start, int end)
    {
        if (start < end)
        {
            int middle = partition(hashList, start, end);
            quickSort(hashList, start, middle - 1);
            quickSort(hashList, middle + 1, end);
        }
        return;
    }

    private class hashPair
    {
        private string key;
        private int value;
        public hashPair(string key, int value)
        {
            this.key = String.Copy(key);
            this.value = value;
        }

        public int getValue()
        {
            return value;
        }

        public string getKey()
        {
            return key;
        }

        public void setValue(int value)
        {
            this.value = value;
        }

        public void setKey(string key)
        {
            this.key = String.Copy(key);
        }
    }
    //Required service 1 end 
}
