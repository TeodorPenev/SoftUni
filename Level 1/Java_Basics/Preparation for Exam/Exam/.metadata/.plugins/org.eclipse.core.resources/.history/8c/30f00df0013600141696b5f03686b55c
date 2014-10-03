import java.lang.reflect.Array;
import java.math.BigDecimal;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class ThreeLargestNumbers {

	public static void main(String[] args) {

		Scanner input = new Scanner(System.in);
		byte count = input.nextByte();
		BigDecimal[] numbers = new BigDecimal[count];

		for (int i = 0; i < count; i++) {
			numbers[i] = input.nextBigDecimal();
		}
		Arrays.sort(numbers);
		for (int i = 0; i < numbers.length; i++) {
			if (count == 1) {
				System.out.println(numbers[count - 1]);
				break;
			}
			if (count == 2) {
				System.out.println(numbers[count - 1]+"\n"+numbers[count - 2]);
				break;
			}
			System.out.println(numbers[count - 1]+"\n"+numbers[count - 2]+"\n"+numbers[count - 3]);
			break;
		}
		

	}

}
