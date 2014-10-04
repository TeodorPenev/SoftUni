import java.util.Scanner;

public class Largest3Rectangles {

	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String reg = input.nextLine().replace("[", " ").replace("]", " ")
				.replace("x", " ").replace("  ", " ").replace("  ", " ").replace("  ", " ").trim();
		String[] values = reg.split(" ");
		int[] area =new int[values.length/2];
		int areaCount =0;
		int sum =0;
		int biggestArea =Integer.MIN_VALUE;
		for (int i = 0; i < values.length; i+=2) {
			area[areaCount] = Integer.parseInt(values[i])*Integer.parseInt(values[i+1]);
			areaCount++;
		}
		for (int i = 0; i < area.length-2; i++) {
			sum = area[i]+area[i+1]+area[i+2];
			if (sum>biggestArea) {
				biggestArea=sum;
			}
		}
		System.out.println(biggestArea);
	}
}