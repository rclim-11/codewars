using System;

public class WeightSort {
	
	public static string orderWeight(string strng) {
		// your code
    string[] list = strng.Split(' ');    
    string result = string.Empty;
    int i=0, j=0;

    for (i=0; i<list.Length; i++) {     
      for (j=0; j<list.Length-i-1; j++) {
        if (weight(list[j]) > weight(list[j+1])) {
          string temp = list[j+1];
          list[j+1] = list[j];
          list[j] = temp;
        }
        int n = list[j].Length > list[j+1].Length ? list[j+1].Length : list[j].Length;
        if (weight(list[j]) == weight(list[j+1]) && String.Compare(list[j], 0, list[j+1], 0, n+1)>0) {
                string temp = list[j+1];
                list[j+1] = list[j];
                list[j] = temp;
         }
      }
    }

      for (i=0; i<list.Length; i++){
        result += list[i] + " ";
      }

      return result.Trim();
  }

    public static int weight(string strng) {
      int sum = 0;      

      foreach (char ch in strng) {
        sum += (int)Char.GetNumericValue(ch);
      }
      return sum;
    }
	
}
