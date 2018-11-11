using System.Collections.Generic;

namespace Psp.Core
{
    public static class Constants
    {
        public static class ProviderAccounts
        {
            public const string GLuePay = "GluePay";
            public const string Adyen = "Adyen";
            public const string Citadel = "Citadel";

            public static List<string> GetAll()
            {
                return new List<string>
                {
                    GLuePay,
                    Adyen,
                    Citadel
                };
            }
        }

        public static class Currencies
        {
            public const string EUR = "EUR";
            public const string UAH = "UAH";

            public static List<string> GetAll()
            {
                return new List<string>
                {
                    EUR,
                    UAH
                };
            }
        }
    }
}
