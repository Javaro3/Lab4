using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab4
{
    public class Lab41
    {
        public string UserString;

        public Lab41(string userString)
        {
            UserString = userString;
        }

        public int GetFactor(int num)
        {
            int resault = 1;
            for (int i = 1; i <= num; i++)
            {
                resault *= i;
            }
            return resault;
        }

        public bool CheckInArr(string[] strArr, string str)
        {
            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i] == str)
                {
                    return false;
                }
            }
            return true;
        }

        public string[] MainFunction()
        {
            Random random = new Random();
            UserString = Regex.Replace(UserString, "[-.?!)(,:]", "");
            string[] arrString = UserString.Split('_');
            string[] resaultString = new string[GetFactor(arrString.Length)];
            string[] indexString = new string[GetFactor(arrString.Length)];
            int kol = 0;
            while (kol < GetFactor(arrString.Length))
            {
                string tmp = "";
                string indexs = "";
                int i = 0;
                while (i < arrString.Length)
                {
                    int word = random.Next(0, arrString.Length);
                    if (CheckInArr(indexs.Split(' '), Convert.ToString(word)))
                    {
                        indexs += Convert.ToString(word) + " ";
                        i++;
                    }
                }
                for (int j = 0; j < arrString.Length; j++)
                {
                    tmp += arrString[Convert.ToInt32(indexs.Split(' ')[j])] + " ";
                }
                if (CheckInArr(indexString, indexs))
                {
                    indexString[kol] = indexs;
                    resaultString[kol] = tmp;
                    kol++;
                }
            }

            return resaultString;
        }

        public static bool operator ==(Lab41 str1, string[] str2)
        {
            string[] str = str1.MainFunction();
            if (str.Length == str2.Length)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (!str1.CheckInArr(str, str2[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        public static bool operator !=(Lab41 str1, string[] str2)
        {
            string[] str = str1.MainFunction();
            if (str.Length == str2.Length)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (!str1.CheckInArr(str, str2[i]))
                    {
                        return true;
                    }
                }
                return false;
            }
            return true;
        }
    }
}
