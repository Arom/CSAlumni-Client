using System;

namespace CSAlumni.Utils {

    public static class StringHelper {

        /// <summary>
        /// Metoda ktora sklada EncodedString Uzywa extension, ktory mozna zawolac na kazdej
        /// instancji stringa
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string EncodeString(string username, string password) {
            return String.Format("{0}:{1}", username, password).EncodeString();
        }

        /// <summary>
        /// Metoda rozszerzajaca obiekt String (dziala na instancjach, w C# nie ma statycznych
        /// Extensions -&gt; moze beda w 6.0)
        /// </summary>
        /// <param name="stringToEncode"></param>
        /// <returns></returns>
        public static string EncodeString(this string stringToEncode) {
            return Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(stringToEncode));
        }

        public static Boolean isEmpty(string s) {
            if (String.IsNullOrEmpty(s))
                return true;
            else {
                return false;
            }
        }
    }
}