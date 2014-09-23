package dd;

import java.util.Scanner;
import java.util.TreeSet;

public class PossibleTriangles {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		boolean exist = false;
		while (true) {
			String[] input =in.nextLine().split(" ");
			if (input[0].equals("End")) {
				break;
			}
			TreeSet<Double> nums = new TreeSet<>();
			nums.add(Double.parseDouble(input[0]));
			nums.add(Double.parseDouble(input[1]));
			nums.add(Double.parseDouble(input[2]));
			double a = nums.first();
			nums.pollFirst();
			double b= nums.first();
			nums.pollFirst();
			double c= nums.first();
			if (a + b >c) {
				exist =true;
				System.out.printf("%.2f+%.2f>%.2f\n",a,b,c);
			}
		}
		if (exist==false) {
			System.out.println("No");
		}

	}
}
