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
    //Elective service 3: delete characters of str2 in str1 and shift the remaining chars correspondingly.
    public string DeleteChar(string str1, string str2)
    {
        char[] char1 = str1.ToCharArray();
        char[] char2 = str2.ToCharArray();
        Boolean[] hash = new Boolean[256];
        foreach (char c in char2)
            hash[c - 1] = true;
        int fast = 0, slow = 0;
        Boolean flag = false;
        while (fast < str1.Length - 1)
        {
            fast++;
            if (hash[char1[slow] - 1])
            {
                flag = true;
                char1[slow] = char1[fast];
                if (!hash[char1[slow] - 1])
                    slow++;
            }
            else
            {
                if (flag)
                    char1[slow] = char1[fast];
                if (!hash[char1[slow] - 1])
                    slow++;
            }
        }
        char1[slow] = '\0';
        string str = new string(char1, 0, slow);
        return str;
    }
    //Elective service 3 end
}
