import java.util.Scanner;

/**
 *  This program checks whether the sequence of numbers entered from the keyboard is decreasing or increasing
 */
public class Sequence {
  public static void main (String[] args) {
    System.out.println("Please enter sequence of numbers and use space for separation:");
    Scanner numbers = new Scanner(System.in);
    String string = numbers.nextLine();
    String stringSeparation[] = string.split(" "); 
    int countOfDecreasing = 1;
    for (int i = 1; i < stringSeparation.length; i++) {
      if (Integer.parseInt(stringSeparation[i]) < Integer.parseInt(stringSeparation[i - 1])) { 
        countOfDecreasing++;
      }
    }
    if (countOfDecreasing == stringSeparation.length) {
      System.out.println("Decreasing sequence");
    } else {
      System.out.println("Nondecreasing sequence");
    }
  }
}
