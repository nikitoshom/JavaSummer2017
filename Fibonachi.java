import java.util.Scanner;

/**
 * This program checks whether the number entered from the keyboard is a nonnegative number of sequence Fibonachi.
 */
public class Fibonachi {
  
  /**
   * In this method, data is entered from the keyboard. It return number entered from keyboard.
   * 
   * @return number with which we will work
   */
  public int inputNumber() {
    System.out.println("Please enter a number:");
    Scanner number = new Scanner(System.in);
    int numberInt = number.nextInt();
    return numberInt;
  }
 
  /**
   * This method test whether the entered number is the number of sequence Fibonachi. 
   * Method get number as a parameter which we want to test, and return true or false depending on the passage of the test.
   * 
   * @param number which we entered from keyboard
   * @return true if number is a number of sequence of Fibonachi and false if don't
   */ 
  public boolean testFibonachi(int numberInt) {
    if (numberInt == 0 || numberInt == 1) {
      return true;
    }
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
    return false;
  }
  
  /**
   * This method outputs the result of this program. 
   * 
   * @param boolean result which in this program say that the number is number of sequence Fibonachi.
   */ 
  public void outputResult (Boolean isNumberFibonachi) {
    if (isNumberFibonachi) {
      System.out.println("It's number of sequence Febonachi");
    } else {
      System.out.println("It isn't number of sequence Febonachi");
    }  
  }
  
  public static void main (String[] args) {
    Fibonachi fibonachiNumber = new Fibonachi();
    fibonachiNumber.outputResult(fibonachiNumber.testFibonachi(fibonachiNumber.inputNumber()));      	
  }
}
