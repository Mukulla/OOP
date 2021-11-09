using System;
using System.Collections.Generic;
using System.Text;

namespace OOP005
{
    class Fractus
    {
        public readonly bool CreatusEst = false;

        readonly int _numerator; 
        readonly int _denominator;
        readonly double _douNume;
        readonly string _printer;        

        public Fractus(int numerator, int denominator)
        {
            if( denominator == 0 )
            {
                Console.WriteLine("Divide by Zerou");
                throw new DivideByZeroException();
            }

            _numerator = numerator;
            _denominator = denominator;

            _douNume = _numerator / _denominator;

            _printer = $"{_numerator}/{_denominator}";

            CreatusEst = true;
        }

        public static Fractus operator ++(Fractus primis) => LibFractus.Do(primis, 1, 0);
        public static Fractus operator --(Fractus primis) => LibFractus.Do(primis, 1, 1);
        public static Fractus operator +(Fractus primis, Fractus secundus) => LibFractus.Do(primis, secundus, 0);
        public static Fractus operator -(Fractus primis, Fractus secundus) => LibFractus.Do(primis, secundus, 1);
        public static Fractus operator *(Fractus primis, Fractus secundus) => LibFractus.Do(primis, secundus, 2);
        public static Fractus operator /(Fractus primis, Fractus secundus) => LibFractus.Do(primis, secundus, 3);

        public static bool operator ==(Fractus primis, Fractus secundus) => LibFractus.Comparator(primis, secundus, 0);        
        public static bool operator !=(Fractus primis, Fractus secundus) => !LibFractus.Comparator(primis, secundus, 0);
        public static bool operator >(Fractus primis, Fractus secundus) => LibFractus.Comparator(primis, secundus, 1);
        public static bool operator <(Fractus primis, Fractus secundus) => LibFractus.Comparator(primis, secundus, 2);
        public static bool operator >=(Fractus primis, Fractus secundus) => !LibFractus.Comparator(primis, secundus, 2);
        public static bool operator <=(Fractus primis, Fractus secundus) => !LibFractus.Comparator(primis, secundus, 1);

        public static Fractus operator +(Fractus primis, int value) => LibFractus.Do(primis, value, 0);
        public static Fractus operator -(Fractus primis, int value) => LibFractus.Do(primis, value, 1);
        public static Fractus operator *(Fractus primis, int value) => LibFractus.Do(primis, value, 2);
        public static Fractus operator /(Fractus primis, int value) => LibFractus.Do(primis, value, 3);

        public static bool operator ==(Fractus primis, int value) => LibFractus.Comparator(primis, value, 0);
        public static bool operator !=(Fractus primis, int value) => !LibFractus.Comparator(primis, value, 0);
        public static bool operator >(Fractus primis, int value) => LibFractus.Comparator(primis, value, 1);
        public static bool operator <(Fractus primis, int value) => LibFractus.Comparator(primis, value, 2);
        public static bool operator >=(Fractus primis, int value) => !LibFractus.Comparator(primis, value, 2);
        public static bool operator <=(Fractus primis, int value) => !LibFractus.Comparator(primis, value, 1);

        public int Numerator { get { return _numerator; } }
        public int Denominator { get { return _denominator; } }
        public double GetDou { get { return _douNume; } }

        public void Print()
        {
            Console.WriteLine(_printer);
        }

        public override string ToString()
        {
            return _printer;
        }
    }   
}
