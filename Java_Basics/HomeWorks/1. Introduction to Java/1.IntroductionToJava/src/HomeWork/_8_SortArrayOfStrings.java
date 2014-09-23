package HomeWork;

import java.util.Scanner;

public class _8_SortArrayOfStrings {

	public static void main(String[] args) {

		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		String[] words = new String[num];
		for (int i = 0; i < num; i++) {
			words[i] = input.next();
		}
		java.util.Arrays.sort(words);
		for (int i = 0; i < words.length; i++) {
			System.out.println(words[i]);
		}
	}

}
