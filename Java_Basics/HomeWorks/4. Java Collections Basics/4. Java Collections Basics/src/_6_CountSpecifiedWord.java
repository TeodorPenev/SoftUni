import java.util.Scanner;

public class _6_CountSpecifiedWord {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] text = input.nextLine().toLowerCase().split("[\\W]+");
		String match = input.next().toLowerCase(); 
		int counter =0;
		
		for (int i = 0; i < text.length; i++) {
			if (text[i].equals(match)) {
				counter++;
			}
		}
		System.out.println(counter);
	}

}
