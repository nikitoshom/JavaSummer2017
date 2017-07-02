import java.util.Scanner;

public class Fibonachi {
  public int number_int;
  public void InputNumber() {
    System.out.println("Please enter a number:");
    Scanner number = new Scanner(System.in);
    String stringWithNumber = number.next();
    number_int = Integer.parseInt(stringWithNumber);
  }
  public boolean TestFibonachi() {
    int firstNumber = 1;
    int secondNumber = 1;
    int thirdNumber = 1;
    boolean resultOfTest = false;
    if (number_int == 0 || number_int == 1 || number_int == -1) {
      resultOfTest = true;
    } else {   
      for (int i = 1; i <= number_int; i++) {
        secondNumber = firstNumber;
        firstNumber = thirdNumber;
        thirdNumber = firstNumber + secondNumber;			
        if (thirdNumber == number_int) {
          resultOfTest = true;
          break;
        }			
      }	
    }	
    return resultOfTest;
  }
  public void OutputResult (Boolean resultOfTest) {
    if (resultOfTest == true) {
      System.out.println("It's number of sequence Febonachi");
    } else {
      System.out.println("It isn't number of sequence Febonachi");
    }  
  }
  public static void main (String[] args) {
    Fibonachi fibonachiNumber = new Fibonachi();
    fibonachiNumber.InputNumber();
    fibonachiNumber.OutputResult(fibonachiNumber.TestFibonachi());      	
  }
}
