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
    //Elective Service 1: list all the combination of the chars in the string(repeated char only count once) 
    public string[] AllCombination(string input)
    {
        string str = Regex.Replace(input, @"[^a-zA-Z0-9]", "");
        char[] chars = str.Trim().ToCharArray();
        Hashtable hash = new Hashtable();
        int count = 0;
        ArrayList charList = new ArrayList();
        foreach (char c in chars)
        {
            if (hash.Contains(c) == false)
            {
                hash.Add(c, 1);
                //charList.Add(c);
            }
        }
        char[] charArray = new char[hash.Count];
        Boolean[] flag = new Boolean[hash.Count];
        foreach (DictionaryEntry entry in hash)
        {
            charArray[count] = (char)entry.Key;
            count++;
        }

        ArrayList allPermutation = new ArrayList();
        dfs(0, "", flag, charArray, allPermutation);
        //for (int i = 0; i < allPermutation.Count; i++)
        //    Console.WriteLine(allPermutation[i].ToString());
        return (string[])allPermutation.ToArray(typeof(string));
    }

    private static void dfs(int step, string s, Boolean[] flag, char[] charArray, ArrayList allPermutation)
    {
        if (step == flag.Length)
        {
            allPermutation.Add(s);
            return;
        }
        for (int i = 0; i < flag.Length; i++)
        {
            if (flag[i] == false)
            {
                flag[i] = true;
                string temp = String.Copy(s);
                s += (charArray[i].ToString());
                //Console.WriteLine(s);
                dfs(step + 1, s, flag, charArray, allPermutation);
                s = String.Copy(temp);
                flag[i] = false;
            }
        }
    }
    //Elective service 1 end
}
