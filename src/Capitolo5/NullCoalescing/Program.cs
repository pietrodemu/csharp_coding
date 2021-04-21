using System;

namespace NullCoalescing
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Operatore Null Coalescing ??
            object nullobject = null;
            object obj = 123;

            var v1 = nullobject ?? 2; //Restituisce 2 perchè nullobject e' null
            var v2 = obj ?? 2; //Restituisce 123 perche' obj e' diverso da null

            // 2. Operatore Null Coalescing come if-then-else o al posto dell'operatore ternario
            string name;
            string str = "";

            // 2.1 semplice if-then-else:
            if (str!=null)
                name = str;
            else
                name = "senza nome";

            // 2.2 Trasformazione in operatore ternario:
            name = (str!=null) ? str : "senza nome";

            // 2.3 Trasformazione in Null coalescing:
            name = str ?? "senza nome";

            // 3. Operatore Null Coalescing come if-then-else concatenati:
            string str2 = null;
            name = str ?? str2 ?? "senza nome";

            // 4. Operatore Null Coalescing come operatore di assegnazione composta:
            string str3 = null;
            str3 ??= "stringa";
            // diventa:
            str3 = str3 ?? "stringa";
            // cioe' assegnera' il valore "stringa" a str3 solo se str3 e' null
        }
    }
}
