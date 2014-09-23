import java.util.Scanner;

public class LongestOddEvenSequence {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String inputStr = input.nextLine().replace("(", " ").replace(")", " ")
				.replaceAll("\\s+", " ").trim();
		String[] inputStrRex = inputStr.split(" ");
		String output = "";
		int count = 0;
		int max = Integer.MIN_VALUE;

		int[] numsArr = new int[inputStrRex.length];

		for (int i = 0; i < inputStrRex.length; i++) {
			numsArr[i] = Integer.parseInt(inputStrRex[i]);
		}
		for (int i = 0; i < numsArr.length; i++) {
			if (numsArr[i] % 2 == 0) {
				output = output + " " + 0;
			} else {
				output = output + " " + 1;
			}
		}
		
		String[] outputArr = output.trim().split(" ");

		String one = "1";
		String zero = "0";
		for (int j = 0, p = 0; p < outputArr.length / 2; j = j + 2, p++) {
			if (outputArr[j].equals(one) && outputArr[j + 1].equals(zero)) {
				count = count + 2;
			}
			else {
				if (outputArr[j+1].equals(one))
					count=count+1;
				}
				if (count > max) {
					max = count;
				}
				count = 0;
			}
		
		count = 0;
		one = "1";
		zero = "0";
		for (int j = 0, p = 0; p < outputArr.length / 2; j = j + 2, p++) {
			if (outputArr[j].equals(zero) && outputArr[j + 1].equals(one)) {
				count = count + 2;
			} else {
				if (count > max) {
					max = count;
				}
				count = 0;
			}
		}

		if (count > max) {
			max = count;
		}
		System.out.println(max);
	}
}
