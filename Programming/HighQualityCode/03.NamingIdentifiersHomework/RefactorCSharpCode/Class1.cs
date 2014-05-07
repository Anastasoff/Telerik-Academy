namespace RefactorCSharpCode
{
    using System;

    public class class_123
    {
        private const int MaxCount = 6;

        private class InClass_class_123
        {
            private void PrintBooleanVariable(bool promenliva)
            {
                string promenlivaKatoString = promenliva.ToString();
                Console.WriteLine(promenlivaKatoString);
            }
        }

        public static void Метод_За_Вход()
        {
            class_123.InClass_class_123 инстанция = new class_123.InClass_class_123();
            //инстанция.Метод_нА_class_InClass_class_123(true);
        }
    }
}