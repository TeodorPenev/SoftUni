import java.util.Scanner;

public class _5_DecimalToHexadecimal {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("Enter decimal number :");
		int dec = input.nextInt();
		String hex =Integer.toHexString(dec).toUpperCase();
		System.out.println("Hex value is: "+hex);
	}

}