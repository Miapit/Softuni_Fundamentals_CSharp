﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L110IntegerTypes
{
    class Program
    {
        static void Main(string[] args)


        {
//            sbyte[-128 …127]: signed 8 - bit[-27 … 27 - 1]
//byte[0 … 255]: unsigned 8 - bit[0 … 28 - 1]
//short[-32 768 … 32 767]: signed 16 - bit[-215 … 215 - 1]
//ushort[0 … 65 535]: unsigned 16 - bit[0 … 216 - 1]
//int[-2 147 483 648 … 2 147 483 647]: signed 32 - bit[-231 … 231 - 1]
//uint[0 … 4 294 967 295]: unsigned 32 - bit[0 … 232 - 1]
//long[-9 223 372 036 854 775 808 … 9 223 372 036 854 775 807]:
//signed 64 - bit[-263 … 263 - 1]
//ulong[0 … 18 446 744 073 709 551 615]: unsigned 64 - bit[0 … 264 - 1]
            byte first = byte.Parse(Console.ReadLine());
            uint second = uint.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            long fourth = long.Parse(Console.ReadLine());
            Console.WriteLine($"{first} {second} {third} {fourth}");
        }
    }
}
