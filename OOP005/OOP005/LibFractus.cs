using System;
using System.Collections.Generic;
using System.Text;

namespace OOP005
{
    struct Geminus
    {
        public int A, B;
    }
    class LibFractus
    {
        static public bool Comparator( Fractus primis, Fractus secundus, int whatDo )
        {
            if( !SiExistat( primis, secundus ) )
            {
                return false;
            }

           
            Geminus tempo;
            if (primis.Denominator == secundus.Denominator)
            {
                tempo = new Geminus();
                tempo.A = primis.Numerator;
                tempo.B = secundus.Numerator;               
            }
            else
            {
                tempo = FitDenominator(primis, secundus);                           
            }

            
            //0 - ==
            //1 - >
            //2 - <
            switch (whatDo)
            {
                case 0:
                    return Comparator(tempo.A, tempo.B, 0);
                //break;
                case 1:
                    return Comparator(tempo.A, tempo.B, 1);
                //break;
                case 2:
                    return Comparator(tempo.A, tempo.B, 2);
            }

            return false;
        }
        static public bool Comparator(Fractus primis, int value, int whatDo)
        {
            if ( !primis.CreatusEst )
            {
                return false;
            }

            //0 - ==
            //1 - >
            //2 - <            
            switch (whatDo)
            {
                case 0:
                    return Comparator(primis.Numerator, value * primis.Denominator, 0);
                //break;
                case 1:
                    return Comparator(primis.Numerator, value * primis.Denominator, 1);
                //break;
                case 2:
                    return Comparator(primis.Numerator, value * primis.Denominator, 2);
            }

            return false;
        }
        static bool Comparator(int A, int B, int whatDo)
        {
            switch (whatDo)
            {
                case 0:
                    return A == B;
                //break;
                case 1:
                    return A > B;
                //break;
                case 2:
                    return A < B;
                //break;
            }

            return false;
        }



        static public Fractus Do( Fractus primis, Fractus secundus, int what )
        {
            if ( !SiExistat( primis, secundus ) )
            {
                return new Fractus(1, 1);
            }
            //0 +
            //1 -
            //2 *
            //3 /
            switch ( what )
            {
                case 0:
                    return BinarActio( primis, secundus, 1 );
                    //break;
                case 1:
                    return BinarActio( primis, secundus, -1 );
                //break;
                case 2:
                    return new Fractus(primis.Numerator * secundus.Numerator, primis.Denominator * secundus.Denominator);
                //break;
                case 3:
                    return new Fractus(primis.Numerator * secundus.Denominator, primis.Denominator * secundus.Numerator);
                    //break;
            }

            return new Fractus(1, 1);
        }
        static public Fractus Do( Fractus primis, int value, int what )
        {
            if ( !primis.CreatusEst )
            {
                return new Fractus(1, 1);
            }
                     
            //0 +
            //1 -
            //2 *
            //3 /
            switch ( what )
            {
                case 0:
                    return new Fractus(primis.Numerator + value  * primis.Denominator, primis.Denominator);
                case 1:
                    return new Fractus(primis.Numerator + -value * primis.Denominator, primis.Denominator);
                case 2:
                    return new Fractus(primis.Numerator * value, primis.Denominator);
                case 3:
                    return new Fractus(primis.Numerator, primis.Denominator * value);
            }

            return new Fractus(primis.Numerator + value * primis.Denominator, primis.Denominator);
        }
        static Fractus BinarActio( Fractus primis, Fractus secundus, int signum )
        {
            int totalNumerator = 0;
            int totalDenominator = 0;

            if(primis.Denominator != secundus.Denominator)
            {              
                totalNumerator = primis.Numerator * secundus.Denominator + signum * ( primis.Denominator * secundus.Numerator );
                totalDenominator = primis.Denominator * secundus.Denominator;
                
                return new Fractus(totalNumerator, totalDenominator);
            }

            totalNumerator = primis.Numerator + secundus.Numerator;
            totalDenominator = primis.Denominator;

            return new Fractus(totalNumerator, totalDenominator);
        }      
        


        static Geminus FitDenominator( Fractus primis, Fractus secundus )
        {
            Geminus tempo = new Geminus();
            tempo.A = primis.Numerator * secundus.Denominator;
            tempo.B = secundus.Numerator * primis.Denominator;

            return tempo;
        }
        static bool SiExistat( Fractus primis, Fractus secundus )
        {
            if ( !primis.CreatusEst || !secundus.CreatusEst )
            {
                return false;
            }
            return true;
        }
    }
}
