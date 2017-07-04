import java.util.Scanner;

public class Fibonachi {
  public int InputNumber() {
    System.out.println("Please enter a number:");
    Scanner number = new Scanner(System.in);
    String stringWithNumber = number.next();
    int numberInt = Integer.parseInt(stringWithNumber);
    return numberInt;
  }
  
  public boolean TestFibonachi(int numberInt) {
    int firstNumber = 1;
    int secondNumber = 1;
    int thirdNumber = 1;
    boolean resultOfTest = false;
    if (numberInt == 0 || numberInt == 1) {
      resultOfTest = true;
    } else {   
      for (int i = 1; i <= numberInt; i++) {
        secondNumber = firstNumber;
        firstNumber = thirdNumber;
        thirdNumber = firstNumber + secondNumber;			
        if (thirdNumber == numberInt) {
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
    fibonachiNumber.OutputResult(fibonachiNumber.TestFibonachi(fibonachiNumber.InputNumber()));      	
  }
}
