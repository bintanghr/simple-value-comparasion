using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    internal class Numbers
    {
        int min, max;
        public int FindMinimum(int number1, int number2)
        {
            min = (number1 < number2) ? number1 : number2;
            return min;
        }
        public int FindMinimum(int number1, int number2, int number3)
        {
            //nested ternary
            min = (number1 < number2) ?
                /* true atau number1 lebih kecil
                number1 dibandingkan lagi dengan number3
                true -> min = number1 
                false -> number3 lebih kecil -> number3 dibandingkan dengan number2
                true -> min = number3 */
                ( (number1 < number3) ? number1 : ((number3 < number2) ? number3 : number2) ) :
                /* false atau number2 lebih kecil
                number2 dibandingkan lagi dengan number3 
                true -> min = number2
                false -> number3 lebih kecil -> number3 dibandingkan dengan number1
                true -> mmin = number 3 */
                ( (number2 < number3) ? number2 : ((number3 < number1) ? number3 : number1) );
            return min;
        }
        public int FindMaximum(int number1, int number2)
        {
            max = (number1 > number2) ? number1 : number2;
            return max;
        }
        public int FindMaximum(int number1, int number2, int number3)
        {
            max = (number1 > number2) ?
                ((number1 > number3) ? number1 : ((number3 > number2) ? number3 : number2)) :
                ((number2 > number3) ? number2 : ((number3 > number1) ? number3 : number1));
            return max;
        }
    }
}
