import java.util.Scanner;

public class Fibonachi {
  public static void main (String[] args) {
    System.out.println("Please enter a number:");
    Scanner number = new Scanner(System.in);
    String string = number.next();
    int number_int = Integer.parseInt(string);
    int firstNumber = 1;
    int secondNumber = 1;
    int thirdNumber = 1;
    int countNumberFebonacci = 0;
    int numberForTest = 0; 
    boolean resultOfTest = false;
    if (number_int == 0 || number_int == 1 || number_int == -1) {
      System.out.println("It's number of sequence Febonachi");
    } else {
      if (number_int < 0) {
        numberForTest = number_int * (-1);
      } else {
        numberForTest = number_int;
      }   
      for (int i = 1; i <= numberForTest; i++) {
        secondNumber = firstNumber;
        firstNumber = thirdNumber;
        thirdNumber = firstNumber + secondNumber;
        countNumberFebonacci = i;			
        if (thirdNumber == numberForTest) {
          resultOfTest = true;
          break;
        }			
      }
      if (resultOfTest == true) {
        if (number_int == numberForTest * Math.pow((-1), (countNumberFebonacci + 2 + 1)) && number_int < 0) {
          System.out.println("It's a negative number of sequence Febonachi");
        } else {
          System.out.println("It isn't number of sequence Febonachi");
        }
        if (number_int > 0) {
          System.out.println("It's number of sequence Febonachi");
        }
      } else {
        System.out.println("It isn't number of sequence Febonachi");
      }
    }		
  }
}
