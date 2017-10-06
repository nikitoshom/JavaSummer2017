using System;
namespace DEV_11_Translit
{
  /*
   * This class take input string and convert from Russian into English and vice versa.
   * There we have 4 strings which include small and big letters of each language and number of iterations(this number = length of each array).
   * And enum field which include languages.
   */
  class StringConvertor
  {
    string[] engUp = { "Kh", "Ts", "Shch", "Sh", "Ch", "A", "B", "V", "G", "D", "E", "Iy", "Ia", "Yu", "Ya", "Ye", "Ye", "Ye", "Ye", "Ye", "Ye", "Y", "\"", "'", "Zh", "Z", "I", "Y", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F"};
    string[] engLow = {"kh", "ts", "shch", "sh", "ch", "a", "b", "v", "g", "d", "e", "iy", "ia", "yu", "ya", "ye", "ye", "ye", "ye", "e",  "e",  "y", "\"", "'", "zh", "z", "i", "y", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "f"};
    string[] rusUp = { "Х",  "Ц",  "Щ",    "Ш",  "Ч",  "А", "Б", "В", "Г", "Д", "Э", "Ый", "Ья", "Ю",  "Я",  "Ьё", "Ьё", "Ъе", "Ъё", "Е",  "Ё",  "Ы", "Ъ",  "Ь", "Ж",  "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф"};
    string[] rusLow = {"х",  "ц",  "щ",    "ш",  "ч",  "а", "б", "в", "г", "д", "э", "ый", "ья", "ю",  "я",  "ье", "ьё", "ъе", "ъё", "е",  "ё",  "ы", "ъ",  "ь", "ж",  "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф"};
    int numIter = 39;
    enum Language { EN, RUS};

    /*
     * This method defines in which language was written input string
     * @param string
     * @return int language (If count of russian letters more than enland letters in string, then program will translate from russian and vice versa.)
     */
    public int ChoseLanguage(string str) {
      int language = (int)Language.EN;
      int countEng = 0, countRus = 0;
      for (int i = 0; i < numIter; i++)
      {
        if (str.Contains(engUp[i]) || str.Contains(engLow[i]))
        {
          countEng++;
        }
        if (str.Contains(rusLow[i]) || str.Contains(rusUp[i]))
        {
          countRus++;
        }
      }
      if (countEng > countRus)
      {
        language = (int)Language.EN;
      }
      else
      {
        language = (int)Language.RUS;
      }
      return language;
    }

    /*
     * This method conert input string. 
     * @param string
     * @return convertString
     */
    public string Translaite(string str)
    {
      string convertString = str;
      switch (ChoseLanguage(str))
      {
        case 0:
          for (int i = 0; i < numIter; i++)
          {
            convertString = convertString.Replace(engUp[i], rusUp[i]);
            convertString = convertString.Replace(engLow[i], rusLow[i]);
          }
          break;
        case 1:
          for (int i = 0; i < numIter; i++)
          {
            convertString = convertString.Replace(rusUp[i], engUp[i]);
            convertString = convertString.Replace(rusLow[i], engLow[i]);
          }
          break;
      }
      return convertString;
    }
  }
}
