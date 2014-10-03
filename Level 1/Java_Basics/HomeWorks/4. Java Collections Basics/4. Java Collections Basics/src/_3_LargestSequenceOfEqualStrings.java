import java.util.Scanner;

public class _3_LargestSequenceOfEqualStrings {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] strings = input.nextLine().split(" ");
		int max = Integer.MIN_VALUE;
		String maxStr = "";
		int counter = 1;
		for (int i = 0; i < strings.length - 1; i++) {
			if (strings[i].equals(strings[i + 1])) {
				counter++;
			} 
			else {
				if (counter > max) {
					max = counter;
					maxStr = strings[i];
				}
				counter=1;
			}
		}
		if (counter > max) {
			max = counter;
			maxStr = strings[strings.length-1];
		}
		for (int j = 0; j < max; j++) {
			System.out.printf("%s ", maxStr);
		}
	}

}
