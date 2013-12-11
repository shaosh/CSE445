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
    //Required service 2: WordFilter 
    public string WordFilter(string str)
    {
        string atStr = @str;
        string oldStr = @"(</?)[^>]+?(/?>)|[^a-zA-Z]";
        string oldStr2 = @"\bare\b|\bam\b|\ba\b|\bthe\b|\ban\b|\bon\b|\bin\b|\bat\b|\bunder\b|\babove\b|\bto\b|\band\b|\bbut\b|\bas\b|\bbecause\b|\bwith\b|\bfor\b|\bso\b|\bthus\b|\btherefore\b|\bhence\b|\bif\b|\belse\b|\bbe\b|\bis\b|\bwhen\b|\bwhere\b|\bwho\b|\bwhat\b|\bwhich\b|\bhow\b|\bof\b|\bbefore\b|\bafter\b|\bthan\b|\bbehind\b|\bbeside\b|\balong\b|\bthrough\b|\bby\b|\bbeen\b|\bwas\b|\bwere\b|\bwhose\b|\binto\b|\bonto\b|\bor\b|\bmoreover\b|\byet\b|\bnevertheless\b|\beither\b|\btoo\b|\bnor\b|\bneither\b|\bonly\b|\bjust\b|\balso\b|\bmerely\b|\bsince\b|\bfrom\b|\babout\b|\bout\b";


        string dataStr1 = Regex.Replace(atStr, oldStr, " ").ToLower();
        string dataStr = Regex.Replace(dataStr1, oldStr2, " ");
        //        Console.WriteLine(dataStr);

        ArrayList wordList = new ArrayList();
        foreach (string s in dataStr.Split())
        {
            if (s.Trim().Length != 0)
            {
                wordList.Add(s);
            }
        }
        string finalStr = string.Join(" ", (string[])wordList.ToArray(typeof(string)));
        //        Console.WriteLine("str: {0}", finalStr);
        return finalStr;
    }
    //Required service 2 end 
}
