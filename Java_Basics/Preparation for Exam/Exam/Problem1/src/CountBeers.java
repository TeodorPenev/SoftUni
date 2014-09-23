import java.util.Scanner;

public class CountBeers {

	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int stacks = 0;
		int beers = 0;

		for (int i = 0; i < 99; i++) {
			String[] line = input.nextLine().split(" ");
			if (line[0].equals("End")) {
				break;
			}
			int count = Integer.parseInt(line[0]);
			String type = line[1];
			if (type.equals("stacks")) {
				stacks += count;
			} else {
				beers += count;
			}
		}
		if (beers > 19) {
			stacks += beers / 20;
			beers = beers % 20;
		}
		System.out.printf("%d stacks + %d beers", stacks, beers);
	}
}
