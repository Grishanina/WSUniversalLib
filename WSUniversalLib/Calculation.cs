using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib

{
    public class Calculation
    {

        public static int GetPriorityForAgent(int priority)
        {
            int agentType = 0;
            float experience = 0;

            Random x = new Random();

            int age = x.Next(18, 100);

            if ((age >= 20) && (age <= 29))
            {
                experience = Convert.ToSingle(age + (age * 0.1));
                agentType = 1;
                priority = 4;
                return priority;
            }
            else if ((age >= 30) && (age <= 39))
            {
                experience = Convert.ToSingle(age + (age * 0.4));
                priority = 3;
                agentType = 2;
                return priority;
            }
            else if ((age >= 40) && (age <= 49))
            {
                experience = Convert.ToSingle(age + (age * 0.7));
                priority = 2;
                agentType = 3;
                return priority;
            }
            else if ((age >= 50) && (age <= 59))
            {
                experience = Convert.ToSingle(age + (age * 0.9));
                priority = 1;
                agentType = 4;
                return priority;
            }
            else
            {
                return age;
            }
        }


        public static List<char> vs = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };


        public static bool CheckKODE(string kode)
        {

            int kolvo = 0;
            if (kode.Length == 17)
            {
                for (int i = 0; i < kode.Length; i++)
                {

                    for (int j = 0; j < vs.Count; j++)
                    {
                        if (kode[i] == vs[j])
                        {
                            kolvo++;

                        }
                    }
                }
                if (kolvo == 17)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static string GetKODECountry(string kode)
        {
            if (CheckKODE(kode))
            {
                for (int i = 10; i <= 17; i++)
                {
                    if (kode[11] == vs[i])
                    {
                        return "Африка";
                    }
                }
                for (int i = 18; i <= 24; i++)
                {
                    if (kode[11] == vs[i])
                    {
                        return "Азия";
                    }

                }
                for (int i = 25; i <= 32; i++)
                {
                    if (kode[11] == vs[i])
                    {
                        return "Европа";
                    }
                }
                for (int i = 1; i <= 5; i++)
                {
                    if (kode[11] == vs[i])
                    {
                        return "Северная Америка";
                    }
                }
                for (int i = 6; i <= 7; i++)
                {
                    if (kode[11] == vs[i])
                    {
                        return "Океания";
                    }
                }
                for (int i = 8; i <= 9; i++)
                {
                    if (kode[11] == vs[i])
                    {
                        return "Южная Америка";
                    }
                }
            }

            return "";
        }
    }
}


