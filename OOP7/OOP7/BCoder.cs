using System;
using System.Collections.Generic;
using System.Text;

using MyLib;

namespace OOP7
{
    class BCoder : ICodar
    {
        //Значения с самозамкнутыми границами
        MyLib.Limited1D[] _symBorders;
        public BCoder()
        {
            _symBorders = new Limited1D[5];

            _symBorders[0] = new Limited1D(0, (int)'0', (int)'9');

            _symBorders[1] = new Limited1D(0, (int)'A', (int)'Z');
            _symBorders[2] = new Limited1D(0, (int)'a', (int)'z');

            _symBorders[3] = new Limited1D(0, (int)'А', (int)'Я');
            _symBorders[4] = new Limited1D(0, (int)'а', (int)'я');
        }
        public string Decode(string someString)
        {
            return Shiftar(someString);
        }
        public string Encode(string someString)
        {
            return Shiftar(someString);
        }



        public string Shiftar(string someString)
        {
            StringBuilder encodedString = new StringBuilder(someString);
            //Получение, смщение, присваивание символа
            for (int i = 0; i < someString.Length; ++i)
            {
                encodedString.Insert(i, (char)GetShiftedIndex(someString[i]));
            }

            return encodedString.ToString().Substring(0, someString.Length);
        }
        int GetShiftedIndex(int codeSymbol)
        {
            //Проверка на принадлежность символа одной из групп
            //Смещение его числового значения на некую величину с учётом самозамкнутых границ
            foreach (var item in _symBorders)
            {
                if (MyLib.Func.IntraAream(codeSymbol, item.GetBorders()) == 0)
                {
                    item.Set(item.GetMax() + item.GetMin() - codeSymbol);
                    return item.Get();
                }
            }
            //Пробел не кодируем
            if (codeSymbol == 32)
            {
                return codeSymbol;
            }

            return -1;
        }
    }
}
