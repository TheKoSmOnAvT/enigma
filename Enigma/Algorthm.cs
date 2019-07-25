using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class Algorthm
    {
        public int Firstroter;
        public int SecondRoter;
        public int ThridRoter;
        public string Input;
        public string Output;

        private char[] Alphabet ={ 'a','b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        private char[] Reflectors = { 'y', 'r', 'u', 'h', 'q', 's', 'l', 'd', 'p', 'x', 'n', 'g', 'o', 'k', 'm', 'i', 'e', 'b', 'f', 'z', 'c', 'w', 'v', 'j', 'a', 't' };
                                    
        private char[] FR = { 'e', 'k', 'm', 'f', 'l', 'g', 'd', 'q', 'v', 'z', 'n', 't', 'o', 'w', 'y', 'h', 'x', 'u', 's', 'p', 'a', 'i', 'b', 'r', 'c', 'j' };
        private char[] SR = { 'a', 'j', 'd', 'k', 's', 'i', 'r', 'u', 'x', 'b', 'l', 'h', 'w', 't', 'm', 'c', 'q', 'g', 'z', 'n', 'p', 'y', 'f', 'v', 'o', 'e' };
        private char[] TR = { 'b', 'd', 'f', 'h', 'j', 'l', 'c', 'p', 'r', 't', 'x', 'v', 'z', 'n', 'y', 'e', 'i', 'w', 'g', 'a', 'k', 'm', 'u', 's', 'q', 'o' };
                                                        

        public Algorthm(int F,int S,int T, string st)
        {
            Firstroter = F - 1;
            SecondRoter = S - 1;
            ThridRoter = T - 1;
            Input = st;
            Action();
        }

        public string OutputString() 
        {
            if (Output != null)
            {
                return Output;
            }
            else
            {
                return null;
            }
        }
        //////////////////////////////////////

        private void CheckPosition() //check position 1,2,3 router and routate 
        {
            if(Firstroter > 25)
            {
                Firstroter = 0;
                SecondRoter = SecondRoter + 1;
            }
            if (SecondRoter > 25)
            {
                SecondRoter = 0;
                ThridRoter = ThridRoter + 1;
            }
            if (ThridRoter > 25)
            {
                ThridRoter = 0;
            }
        }

        private int SearchLetter(char a) // search letter in alphabet
        {
            for(int i =0;i< Alphabet.Length;i++)
            {
                if (Alphabet[i]==a )
                {
                    return i;
                }
            }
            return 0;
        }
        private int SearchLetterReflector(char a) //search letter in reflector 
        {
            for (int i = 0; i < Reflectors.Length; i++)
            {
                if (Reflectors[i] == a)
                {
                    return i;
                }
            }
            return 0;
        }
        private int CheckRotor(char a, char[] h) //search letter in reflector 
        {
            for (int i = 0; i < h.Length; i++)
            {
                if (h[i] == a)
                {
                    return i;
                }
            }
            return 0;
        }


        private int SumTwo(int f, int s) // sum two variables
        {
            int k = f + s;
            if (k < 0)
            {
                k = 25+ k;
            }
            if (k > 25)
            {
                k = k - 25;
            }
            return k;
        }


        private int Sums(int f,int s, int t) //sum and dif variables
        {
            int k = f + (s-t);
            if(k<0)
            {
                k = 25 + k;
            }
            if (k > 25)
            {
                k = k - 25;
            }

            return k;
        }

        private int Divs(int f, int s, int t) //dif variables
        {
            int k = f - (s - t);
            if (k < 0)
            {
                k = 25 + k;
            }
            if (k > 25)
            {
                k = k - 25;
            }

            return k;
        }

        private int Diffirence(int f, int s) // diff two variables
        {
            int k = f  - s;
            if (k < 0)
            {
                k = 25 + k;
            }
            if (k > 25)
            {
                k = k - 25;
            }

            return k;
        }

        public void Action()
        {
            string OP = "";
            for (int i = 0; i < Input.Length; i ++)
            {
               // Firstrouter = Firstrouter + 1;
               // CheckPosition();
                //8 deals
                //1
                int NumL = SumTwo(SearchLetter(Input[i]) , Firstroter); 
                //2
                 NumL = Sums(SearchLetter(FR[NumL]),SecondRoter, Firstroter);
                //3 
                NumL = Sums(SearchLetter(SR[NumL]), ThridRoter, SecondRoter);
                //4  
                NumL = Diffirence(SearchLetter(TR[NumL]) , ThridRoter);

                /*//  */
                /*NumL*/  NumL = SearchLetter(Reflectors[NumL]);
                /*//  */

                //5  
                NumL = SumTwo(
                                 CheckRotor(Alphabet[NumL],TR),
                                 ThridRoter);
                //6
                NumL = Divs(
                             CheckRotor(Alphabet[NumL],SR) ,
                             ThridRoter ,
                             SecondRoter);
                //7  
                NumL = Divs(
                             CheckRotor(Alphabet[NumL],FR) ,
                             SecondRoter ,
                             Firstroter);
                //8 
                NumL = Diffirence(NumL, Firstroter);
                OP = OP + Alphabet[NumL];
               
            }
            Output = OP;
        }

    }
}
