package HomeWork;
import java.util.Scanner;

public class _6_SumTwoNumbers {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		System.out.println("Please enter a two number :");
		int num1 = input.nextInt();
		int num2 = input.nextInt();
		System.out.printf("The sum of numbers is %d", num1 + num2);
	}
}