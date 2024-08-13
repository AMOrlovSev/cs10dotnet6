﻿using static System.Console;

//WriteLine($"sbyte - number of bytes: {sizeof(sbyte)}, min: {sbyte.MinValue}, max {sbyte.MaxValue}");
//WriteLine($"byte - number of bytes: {sizeof(byte)}, min: {byte.MinValue}, max {byte.MaxValue}");
//WriteLine($"short - number of bytes: {sizeof(short)}, min: {short.MinValue}, max {short.MaxValue}");
//WriteLine($"ushort - number of bytes:  {sizeof(ushort)} , min:  {ushort.MinValue} , max  {ushort.MaxValue}");
//WriteLine($"int - number of bytes:  {sizeof(int)} , min:  {int.MinValue} , max  {int.MaxValue}");
//WriteLine($"uint - number of bytes:  {sizeof(uint)} , min:  {uint.MinValue} , max  {uint.MaxValue}");
//WriteLine($"long - number of bytes: {sizeof(long)}, min: {long.MinValue}, max {long.MaxValue}");
//WriteLine($"ulong - number of bytes: {sizeof(ulong)}, min: {ulong.MinValue}, max {ulong.MaxValue}");
//WriteLine($"float - number of bytes: {sizeof(float)}, min: {float.MinValue}, max {float.MaxValue}");
//WriteLine($"double - number of bytes: {sizeof(double)}, min: {double.MinValue}, max {double.MaxValue}");
//WriteLine($"decimal - number of bytes: {sizeof(decimal)}, min: {decimal.MinValue}, max {decimal.MaxValue}");

WriteLine("--------------------------------------------------------------------------");
WriteLine("Type    Byte(s) of memory               Min                            Max");
WriteLine("--------------------------------------------------------------------------");
WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,30} {byte.MaxValue,30}");
WriteLine($"short   {sizeof(short),-4} {short.MinValue,30} {short.MaxValue,30}");
WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,30} {ushort.MaxValue,30}");
WriteLine($"int     {sizeof(int),-4} {int.MinValue,30} {int.MaxValue,30}");
WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,30} {uint.MaxValue,30}");
WriteLine($"long    {sizeof(long),-4} {long.MinValue,30} {long.MaxValue,30}");
WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,30} {ulong.MaxValue,30}");
WriteLine($"float   {sizeof(float),-4} {float.MinValue,30} {float.MaxValue,30}");
WriteLine($"double  {sizeof(double),-4} {double.MinValue,30} {double.MaxValue,30}");
WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,30} {decimal.MaxValue,30}");
WriteLine("--------------------------------------------------------------------------");