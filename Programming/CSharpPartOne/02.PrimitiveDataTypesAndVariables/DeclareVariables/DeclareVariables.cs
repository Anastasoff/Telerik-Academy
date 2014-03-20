using System;

// 1. Declare five variables choosing for each of them the most appropriate of the types:
// byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
// 52130, -115, 4825932, 97, -10000.
class DeclareVariables
{
    static void Main()
    {
        ushort ushortVar = 52130;
        sbyte sbyteVar = -115;
        uint uintVar = 4825932;
        byte byteVar = 97;
        short shortVar = -10000;

        Console.WriteLine("ushort: {0,5}\nsbyte: {1,6}\nuint: {2}\nbyte: {3,7}\nshort: {4}", 
            ushortVar, sbyteVar, uintVar, byteVar, shortVar);
    }
}
