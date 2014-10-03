import java.util.Scanner;


public class _4_LongestIncreasingSequence {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] strings = input.nextLine().split(" ");
		int[] numbers = new int[strings.length];
		int counter=1;
		int max =Integer.MIN_VALUE;
		int startPoint =0;
		
		for (int i = 0; i < numbers.length; i++) {
			numbers[i]=Integer.parseInt(strings[i]);
		}
		
		System.out.printf("%d ",numbers[0]);
        
		for (int i = 1; i < numbers.length; i++) {
			if (numbers[i]>numbers[i-1]) {
				System.out.printf("%d ",numbers[i]);
				counter++;
			}
			else {
				System.out.println();
				System.out.printf("%d ",numbers[i]);
				if (max<counter) {
					max=counter;
					startPoint =i-counter;
				}
				counter =1;
			}
		}
		if (max<counter) {
			max=counter;
			startPoint =numbers.length-counter;
		}
		System.out.println();
		System.out.print("Longest: ");
		for (int i =startPoint; i < startPoint+max; i++) {
			System.out.printf("%d ",numbers[i]);
		}
	}

}
