using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyLib;

namespace OOP7
{
    class ACoder : ICodar
    {
        //Значения с самозамкнутыми границами
        MyLib.Clausa1D[] _symBorders;

        public ACoder()
        {
            _symBorders = new Clausa1D[3];
            _symBorders[0] = new Clausa1D(0, (int)'0', (int)'9');
            _symBorders[1] = new Clausa1D(0, (int)'A', (int)'z');
            _symBorders[2] = new Clausa1D(0, (int)'А', (int)'я');
        }

        public string Decode(string someString)
        {
            return Shiftar(someString, -1);
        }
        public string Encode(string someString)
        {
            return Shiftar(someString, 1);
        }



        public string Shiftar(string someString, int value)
        {
            StringBuilder encodedString = new StringBuilder(someString);
            //Получение, смщение, присваивание символа
            for (int i = 0; i < someString.Length; ++i)
            {
                encodedString.Insert(i, (char)GetShiftedIndex(someString[i], value));
            }

            return encodedString.ToString().Substring(0, someString.Length);
        }
        int GetShiftedIndex(int codeSymbol, int shiftValue)
        {
            //Проверка на принадлежность символа одной из групп
            //Смещение его числового значения на некую величину с учётом самозамкнутых границ
            foreach (var item in _symBorders)
            {
                if (MyLib.Func.IntraAream(codeSymbol, item.GetBorders()) == 0)
                {
                    item.Set(codeSymbol);
                    item.Do(shiftValue, 0);

                    return item.Get();
                }
            }
            //Пробел не кодируем
            if(codeSymbol == 32)
            {
                return codeSymbol;
            }

            return -1;
        }
    }
}
