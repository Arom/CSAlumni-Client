using System;

namespace CSAlumni.Utils {

    public static class StringHelper {

        /// <summary>
        /// Returns the encoded string for authentication purposes. 
        /// </summary>
        public static string EncodeString(string username, string password) {
            return String.Format("{0}:{1}", username, password).EncodeString();
        }

        /// <summary>
        /// Returns the encoded string for authentication purposes. 
        /// </summary>
        public static string EncodeString(this string stringToEncode) {
            return Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(stringToEncode));
        }
        /// <summary>
        /// Checkes wether a passed string is null or empty.
        /// </summary>
        /// <param name="s">String to be checked.</param>
        /// <returns>String empty/null or not.</returns>
        public static Boolean isEmpty(string s) {
            return (String.IsNullOrEmpty(s));
             
        }
    }
}