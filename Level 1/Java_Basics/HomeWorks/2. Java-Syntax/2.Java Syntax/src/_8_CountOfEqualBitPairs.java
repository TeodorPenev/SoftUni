import java.util.Scanner;

public class _8_CountOfEqualBitPairs {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int dec = input.nextInt();
		String[] bin = Integer.toBinaryString(dec).split("");
		int count = 0;

		for (int i = 0; i < bin.length - 1; i++) {
			String check = bin[i] + bin[i + 1];
			if (check.equals("11") || check.equals("00")) {
				count++;
			}
		}
		System.out.println(count);
	}
}
