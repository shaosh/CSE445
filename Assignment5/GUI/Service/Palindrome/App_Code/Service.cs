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
    //Elective Service 2: find the length of the longest palindrome sequence in given string
    public int Palindrome(string str)
    {
        char[] charStart = str.ToCharArray();
        int maxLength1 = 0;
        int temp1 = 0;
        int maxLength2 = 0;
        int temp2 = 0;
        for (int i = 0; i < str.Length; i++)
        {
            temp1 = middle(charStart, i);
            if (temp1 > maxLength1)
            {
                maxLength1 = temp1;
            }
            temp2 = mirror(charStart, i);
            if (temp2 > maxLength2)
            {
                maxLength2 = temp2;
            }
        }
        if (maxLength1 > maxLength2)
        {
            return maxLength1;
        }
        else
        {
            return maxLength2;
        }
    }

    private static int middle(char[] start, int point)
    {
        int length = start.Length;
        int maxLength = 1;
        int left = point - 1;
        int right = point + 1;
        while (left >= 0 && right < length)
        {
            if (start[left] == start[right])
            {
                left--;
                right++;
                maxLength += 2;
            }
            else
                break;
        }
        return maxLength;
    }

    private static int mirror(char[] start, int point)
    {
        int length = start.Length;
        int maxLength1 = 0;
        int maxLength2 = 0;
        int left1 = point;
        int right1 = point + 1;
        while (left1 >= 0 && right1 < length)
        {
            if (start[left1] == start[right1])
            {
                left1--;
                right1++;
                maxLength1 += 2;
            }
            else
                break;
        }
        int left2 = point - 1;
        int right2 = point;
        while (left2 >= 0 && right2 < length)
        {
            if (start[left2] == start[right2])
            {
                left2--;
                right2++;
                maxLength2 += 2;
            }
            else
                break;
        }

        if (maxLength1 < maxLength2)
        {
            return maxLength2;
        }
        else if (maxLength1 > maxLength2)
        {
            return maxLength1;
        }
        else
        {
            return maxLength1;
        }
    }
    //Elective service 2 end
}
