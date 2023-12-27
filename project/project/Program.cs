using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

        }

        //Verilmiş 3 ədədin cəmini tapan method(həm int, həm double ədədlər üçün)
        static int sum(int num,int num2,int num3)
        {
            int result = num +num2 +num3;

            return result;


        }
        static double sum(double num, double num2, double num3)
        {
            double result = num + num2 + num3;

            return result;


        }



        //Verilmiş ədədlər siyahısındaki bütün ədədlərin cəmini tapan method (həm int, həm double ədədlər üçün)

        static int listSum(int[] num)
        {
            int sum  = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];



            }

            return sum;
        }

        static double listSum(double[] num)
        {
            double sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];



            }

            return sum;
        }


        //Verilmiş yazıda veirlmiş charın yerləşdiyi ilk indexi tapan method (yoxdursa -1 qaytarı)
        static int findFirstIndex(string text,char letter)
        {
            for (int i = 0;i < text.Length;i++)
            {
                int index = 0;

                if (text[i] == letter)
                {
                    index= i;
                    return index;
                }


            }
            return -1;


        }

        //Verilmiş yazıda veirlmiş charın yerləşdiyi son indexi tapan method (yoxdursa -1 qaytarı)

        static int findLastIndex(string text, char letter)
        {

            int index = 0;
            
            for(int i = text.Length - 1;i>=0 ; i--)
            {
                if (text[i] == letter)
                {
                    index = i;


                }

            }

            return index;
        }
        //Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan method
        static int bigNum(int[] num)
        {
            
            int bigNum=0;

            for (int i = 0;0<num.Length; i++)
            {
                if (num[i] > bigNum)
                {
                    bigNum = num[i];

                }


            }

            return bigNum;

        }
        //Verilmiş ədədin müsbət və cüt olub olmadığını tapan method
        static bool checkMusbetCut(int num)
        {

            if (num>0&&num%2==0)
            {
                return true;

            }
            else return false;

        }
        //Verilmiş ədədlər siyahısındaki müsbət və cüt ədədlərin sayını tapan method
        static int numberMusbetCut(int[] num)
        {
            int count = 0;

            for (int i=0;i<num.Length;i++)
            {
                if (num[i] > 0 && num[i] % 2 == 0)
                {
                    count++;


                }

            }

            return count;

        }

        //Verilmiş ədədlər siyahısındaki müsbət və cüt ədədlərdən ibarət yeni bir array düzəldən method.
        static int[] listMusbetCut(int[] num)
        {

            int count = 0;
            for (int i = 0; i < num.Length; i++)
            {

                if ((num[i] > 0) && (num[i] %2 == 0))
                {

                    count++;


                }

            }

            int[] list = new int[count];
            int index = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if ((num[i] > 0 && num[i]%2 ==0))
                {

                    list[index] = num[i];
                    index++;

                }


            }

            return list;
 

        }

        //Verilmiş ədədlər siyahısından tərsinə düzülmüz yeni bir array qaytaran method.
        //(misalçün verilən arra {10,20,30} olarsa methoddan return olunan array {30,20,10} olacaq.

        static int[] reverse(int[] list)
        {

            int[] newList = new int[list.Length];

            int index = 0;

            for(int i = list.Length - 1; i>=0; i--)
            {

                newList[index] = list[i];
                index++;


            }

            return newList;


        }

        //Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən method
        static string leftNewlist(string str)
        {
            string newList = "";
            int index = 0;
            for (int i = 0;i < str.Length;i++)
            {

                if (str[i] !=' ')
                {
                     index = i;

                    break;
                }

            }
            

            for(int i = index;i<str.Length ; i++)
            {
                newList += str[i];



            }

            return newList; 

        }



        //Verilmiş yazıdan sonundaki boşluqlar silinmiş yeni string düzəldən method
        static string rightNewlist(string str)
        {

            string newStr = "";

            int index = 0;

            for(int i = str.Length - 1; i>=0;i--)
            {

                if (str[i] != ' ')
                {
                    index=i;
                    break;

                }

            }

            for(int i=0;i<=index ; i++)
            { 
            
                
                newStr += str[i];
            
            
            
            }

            return newStr;


        }



    }
}
