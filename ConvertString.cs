using System;
namespace DEV_11_Translit
{
  /*
   * This class take input string and conver from Cyrillica into Latin and vice versa.
   * There we have 4 strings which include small and big letters of each language.
   */
  class ConvertString
  {
    string[] lat_up = { "Kh", "Ts", "Shch", "Sh", "Ch", "A", "B", "V", "G", "D", "E", "Iy", "Ia", "Yu", "Ya", "Ye", "Ye", "Ye", "Ye", "Ye", "Ye", "Y", "\"", "'", "Zh", "Z", "I", "Y", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F"};
    string[] lat_low = {"kh", "ts", "shch", "sh", "ch", "a", "b", "v", "g", "d", "e", "iy", "ia", "yu", "ya", "ye", "ye", "ye", "ye", "e",  "e",  "y", "\"", "'", "zh", "z", "i", "y", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "f"};
    string[] rus_up = { "Х",  "Ц",  "Щ",    "Ш",  "Ч",  "А", "Б", "В", "Г", "Д", "Э", "Ый", "Ья", "Ю",  "Я",  "Ьё", "Ьё", "Ъе", "Ъё", "Е",  "Ё",  "Ы", "Ъ",  "Ь", "Ж",  "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф"};
    string[] rus_low = {"х",  "ц",  "щ",    "ш",  "ч",  "а", "б", "в", "г", "д", "э", "ый", "ья", "ю",  "я",  "ье", "ьё", "ъе", "ъё", "е",  "ё",  "ы", "ъ",  "ь", "ж",  "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф"};

    /*
     * This method defines in which language was written input string
     * @param string
     * @return boolean LanguageEN (if LanguageEN == true, it means that our string was written in English, if LanguageEN == false, string was written in Russia)
     */
    public Boolean ChoseLanguage(string str) {
      Boolean languageEN = false;
      for (int i = 0; i < lat_low.Length; i++)
      {
        if (str.Contains(lat_up[i]) || str.Contains(lat_low[i]))
        {
          languageEN = true;
        }
      }
      return languageEN;
    }

    /*
     * This method conert input string. 
     * @param string
     * @return convertString
     */
    public string Transliter(string str)
    {
      string convertString = str;
      if (ChoseLanguage(str))
      {
        for (int i = 0; i < lat_low.Length; i++)
        {
          convertString = convertString.Replace(lat_up[i], rus_up[i]);
          convertString = convertString.Replace(lat_low[i], rus_low[i]);
        }
      }
      else
      {
        for (int i = 0; i < lat_low.Length; i++)
        {
          convertString = convertString.Replace(rus_up[i], lat_up[i]);
          convertString = convertString.Replace(rus_low[i], lat_low[i]);
        }
      }
      return convertString;
    }
  }
}
