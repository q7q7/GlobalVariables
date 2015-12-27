using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GlobalVariables
{
    class Logic
    {
        public string Source { get; set; }
        public List<string> Functions { get; set; } //Массив функций
        public List<string> Variables { get; set; } // Массив переменных

    public Logic (string CodeList)
        {
            Source = CodeList;
            Functions = new List<string>();
            Variables = new List<string>();
            ChangeBeginEnd();
            WriteVariables();
            WriteFunctionsAndProcedures(Source);
            AnalysMetrix();
        }


    public void WriteFunctionsAndProcedures(string CodeList)
    {
        Regex procPattern = new Regex("procedure ", RegexOptions.IgnoreCase);
        Regex funcPattern = new Regex("function ", RegexOptions.IgnoreCase);
        CodeList = CodeList.Remove(0, CodeList.IndexOf("};", StringComparison.CurrentCultureIgnoreCase) + 4);
        List<int> indexes = new List<int>(); 
        for (int i = 0; i < procPattern.Matches(CodeList).Count; i++)
        {
            indexes.Add(procPattern.Matches(CodeList)[i].Index);
        }
        for (int i = 0; i < funcPattern.Matches(CodeList).Count; i++)
        {
            indexes.Add(funcPattern.Matches(CodeList)[i].Index);
        }
        for (int i = 0; i < indexes.Count(); i++)
        {
            Functions.Add(NextTextInBrakes(CodeList.Remove(0, indexes[i])));
        }
    }
    private int EndBrakePosition(string CodeList)
    {
        int a = 0;
        int b = 0;
        for (int i = 0; (i < CodeList.Length); i++)
        {
            if (CodeList[i] == '{')
            {
                a++;
            }
            if (CodeList[i] == '}')
            {
                a--;
                if (a == 0)
                {
                    b = i;
                    break;
                }
            }
        }
        return b;
    }
    private string NextTextInBrakes(string CodeList)
    {
        string result = CodeList.Remove(0, CodeList.IndexOf('{') + 1).Remove(1 + EndBrakePosition(CodeList.Remove(0, CodeList.IndexOf('{'))));

        return result;
    }

    public void ChangeBeginEnd()
    {
        string CodeList = Source;
        Regex begin = new Regex(@"begin\W", RegexOptions.IgnoreCase);
        CodeList = Regex.Replace(CodeList, @"begin\W", "{");
        Regex end = new Regex(@"\Wend", RegexOptions.IgnoreCase);
        CodeList = Regex.Replace(CodeList, @"\Wend", "}");
        Source = CodeList;
    }

    public void WriteVariables()
    {
        string buffer = Source;
        buffer = Source.Remove(0, buffer.IndexOf("};", StringComparison.CurrentCultureIgnoreCase) + 4);
        if (buffer.IndexOf("procedure ", StringComparison.CurrentCultureIgnoreCase) > 0 &&
            buffer.IndexOf("function ", StringComparison.CurrentCultureIgnoreCase) > 0)
        {
            if (buffer.IndexOf("procedure ", StringComparison.CurrentCultureIgnoreCase) >
                buffer.IndexOf("function ", StringComparison.CurrentCultureIgnoreCase))
            {
                buffer = buffer.Remove(buffer.IndexOf("function ", StringComparison.CurrentCultureIgnoreCase));
            }
            else
            {
                buffer = buffer.Remove(buffer.IndexOf("procedure ", StringComparison.CurrentCultureIgnoreCase));
            }
        }
        if (buffer.IndexOf("function ", StringComparison.CurrentCultureIgnoreCase) < 0 &&
            buffer.IndexOf("procedure ", StringComparison.CurrentCultureIgnoreCase) > 0)
        {
            buffer = buffer.Remove(buffer.IndexOf("procedure ", StringComparison.CurrentCultureIgnoreCase));
        }
        if (buffer.IndexOf("function ", StringComparison.CurrentCultureIgnoreCase) > 0 &&
            buffer.IndexOf("procedure ", StringComparison.CurrentCultureIgnoreCase) < 0)
        {
            buffer = buffer.Remove(buffer.IndexOf("function ", StringComparison.CurrentCultureIgnoreCase));
        }
        List<string> FirstArray = buffer.Split(';').ToList();
        for (int i = 0; i < FirstArray.Count - 1; i++)
        {
            string vars = FirstArray[i].Split(':')[0];
            List<string> SecondArray = vars.Split(',').ToList();
            foreach (var a in SecondArray)
            {
                var s = a.Split(' ');
                s = s.OrderByDescending(x => x.Length).ToArray();
                Variables.Add(s[0]);
            }
        }
    }


    public string AnalysMetrix()
    {
        int aup = 0;
        foreach (var f in Functions)
        {
            bool exists = false;
            foreach (var v in Variables)
            {
                if (f.IndexOf(v, StringComparison.CurrentCultureIgnoreCase) > 0)
                {
                    exists = true;
                }
            }
            if (exists == true)
            {
                aup++;
            }
        }

        int pup = 0;

        pup = Functions.Count * Variables.Count;
        float rup = (float)aup / (float)pup;
        if (pup > 0) 
        {
            return  "Количество глобальных переменных = " + Variables.Count + "\n" + "Количество методов = " + Functions.Count + "\n" + "Количество возм. обращений (Pup) = " + pup + "\n" + "Количество факт. обращений (Aup) = " + aup + "\n" + "Rup (Aup/Pup) = " + rup;
        }
        else
            return " Этот код не имеет глобальных переменных";
    }

    }
}

