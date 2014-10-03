import java.util.Scanner;


public class _5_AngleUnitConverter {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		double result = 0;
		input.nextLine();
		for (int i = 0; i < num; i++) {
			String temp[]=input.nextLine().split(" ");
			if (temp[1].equals("deg")) {
				result = Double.parseDouble(temp[0])*(Math.PI/180);
				System.out.printf("%f rad\n",result);
			}
			else {
				result = Double.parseDouble(temp[0])*(180/Math.PI);
				System.out.printf("%f rad\n",result);
			}
		}

	}

}
