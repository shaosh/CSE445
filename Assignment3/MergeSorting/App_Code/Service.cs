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
    //Elective service 4: merge sort
    public string MergeSorting(string chars)
    {
        string temp;
        if (chars.Contains(@"[^a-zA-Z\s]"))
        {
            return "Wrong input!";
        }
        else
        {
            temp = chars.Replace(" ", "");
            char[] charList = temp.ToCharArray();
            string result = "";
            if (charList.Length != 0)
            {
                mergeSort(charList, 0, charList.Length - 1);
                foreach (char i in charList)
                {
                    result += i.ToString();
                }
            }
            return result;
        }
    }

    private static void merge(char[] charList, int start, int end, int mid)
    {
        int llen = mid - start + 2;
        int rlen = end - mid + 1;
        char[] left = new char[llen];
        char[] right = new char[rlen];
        left[llen - 1] = (char)123;
        right[rlen - 1] = (char)123;
        for (int i = 0; i < llen - 1; i++)
        {
            left[i] = charList[start + i];
        }
        for (int i = 0; i < rlen - 1; i++)
        {
            right[i] = charList[mid + 1 + i];
        }
        int j = 0, k = 0;
        for (int i = start; i < end + 1; i++)
        {
            if (left[j] < right[k])
            {
                charList[i] = left[j];
                j++;
            }
            else
            {
                charList[i] = right[k];
                k++;
            }
        }
        return;
    }

    private static void mergeSort(char[] chars, int start, int end)
    {
        int mid = (end + start) / 2;
        if (start < end)
        {
            mergeSort(chars, start, mid);
            mergeSort(chars, mid + 1, end);
            merge(chars, start, end, mid);
        }
        return;
    }
    //Elective service 4 end
}
