import java.util.ArrayList;
import java.util.Scanner;

public class MirrorsNumbers {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n =in.nextInt();
		in.nextLine();
		ArrayList nums = new ArrayList<>();
		ArrayList revert = new ArrayList<>();
		String[] input =in.nextLine().split(" ");
		for (int i = 0; i < n; i++) {
			nums.add(input[i]);
		}
		for (int i = 0; i < n; i++) {
			String temp = input[i];
			String revertted =""+temp.charAt(3) + temp.charAt(2) + temp.charAt(1)
					+ temp.charAt(0);
			revert.add(revertted);
		}
	}

}
