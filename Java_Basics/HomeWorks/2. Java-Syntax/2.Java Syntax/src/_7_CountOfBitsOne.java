import java.util.Scanner;

public class _7_CountOfBitsOne{

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int dec = input.nextInt();
		String[] bin = Integer.toBinaryString(dec).split("");
		int count = 0;
		for (int i = 0; i < bin.length; i++) {
			if (bin[i].equals("1")) {
				count++;
			}
		}
		System.out.println(count);
	}

}
