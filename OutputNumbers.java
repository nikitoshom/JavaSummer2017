public class OutputNumbers {
  public static void main (String[] args) {
    for (int i = 0; i <= 100; i++) {
      if (i % 3 == 0 && i % 5 == 0) {
        System.out.println("Tutti-Frutti");
      } else if (i % 3 == 0) {
        System.out.println("Tutti");
      } else if (i % 5 == 0) {
        System.out.println("Frutti");
      } else {
        System.out.println(i);			
      }
    }
  }
}
