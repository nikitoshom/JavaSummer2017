import java.util.Scanner;

/**
 * This program checks whether the number entered from the keyboard is a nonnegative number of sequence Fibonachi.
 */
public class Fibonachi {
  public int InputNumber() {
    System.out.println("Please enter a number:");
    Scanner number = new Scanner(System.in);
    int numberInt = number.nextInt();
    return numberInt;
  }
  
  public boolean TestFibonachi(int numberInt) {
    if (numberInt == 0 || numberInt == 1) {
      return true;
    } else { 
      int firstNumber = 1;
      int secondNumber = 1;
      int thirdNumber = 1;
      for (int i = 1; i <= numberInt; i++) {
        secondNumber = firstNumber;
        firstNumber = thirdNumber;
        thirdNumber = firstNumber + secondNumber;			
        if (thirdNumber == numberInt) {
          return true;
        }			
      }	
    }	
    return false;
  }
  
  public void OutputResult (Boolean resultOfTest) {
    if (resultOfTest) {
      System.out.println("It's number of sequence Febonachi");
    } else {
      System.out.println("It isn't number of sequence Febonachi");
    }  
  }
  
  public static void main (String[] args) {
    Fibonachi fibonachiNumber = new Fibonachi();
    fibonachiNumber.OutputResult(fibonachiNumber.TestFibonachi(fibonachiNumber.InputNumber()));      	
  }
}
