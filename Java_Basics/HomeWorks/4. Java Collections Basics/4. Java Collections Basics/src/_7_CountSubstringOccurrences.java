import java.util.Scanner;

public class _7_CountSubstringOccurrences {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String text = input.nextLine().toLowerCase();
		String match = input.next().toLowerCase();
		int atPos=0;
		int index = 0;
		int counter = 0;
		
		while (true) {
			
			index = text.indexOf(match,atPos);
			if (index != -1) {
				counter++;
			}
			else {
				break;
			}
			atPos=index+1;
			
		}
		System.out.println(counter);
	}

}
