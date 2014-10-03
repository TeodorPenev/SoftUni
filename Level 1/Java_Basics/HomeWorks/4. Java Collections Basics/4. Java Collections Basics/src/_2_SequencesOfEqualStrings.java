import java.util.Scanner;

public class _2_SequencesOfEqualStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] strings = input.nextLine().split(" ");
		int counter = 1;
		for (int i = 0; i < strings.length - 1; i++) {
			if (strings[i].equals(strings[i + 1])) {
				counter++;
			} else {

				for (int j = 0; j < counter; j++) {
					System.out.printf("%s ", strings[i]);
				}
				System.out.println();
				counter = 1;
			}
		}
		for (int j = 0; j < counter; j++) {
			System.out.printf("%s ", strings[strings.length - 1]);
		}
	}

}
