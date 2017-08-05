import java.util.Scanner;

/**
 *  This program checks whether the sequence of numbers entered from the keyboard is decreasing or Nondecreasing
 */
public class Sequence {
  /**
   *  Determines that the input sequence of integers is non-decreasing
   *
   * @param stringSeparation a sequence for check
   */
  public void checkOnNondecreasing (String[] stringSeparation) {
    if (stringSeparation.length == 1) {
      System.out.println("It isn't a sequence, it is a number.");
    } else {
      for (int i = 0; i < stringSeparation.length - 1; i++) {
        if (Integer.parseInt(stringSeparation[i]) > Integer.parseInt(stringSeparation[i + 1])) { 
          System.out.println("Decreasing sequence");
          return;
        }
      }
      System.out.println("Nondecreasing sequence");
    }
  }
  
  public static void main (String[] args) { 
    Sequence sequence = new Sequence();
    if (args.length == 0) {
      System.out.println("Please enter sequence of numbers and use space for separation:");
      Scanner numbers = new Scanner(System.in);
      String string = numbers.nextLine();
      String stringSeparation[] = string.split(" ");
      sequence.checkOnNondecreasing (stringSeparation);
    } else {
      sequence.checkOnNondecreasing (args);
    }    
  } 
}
