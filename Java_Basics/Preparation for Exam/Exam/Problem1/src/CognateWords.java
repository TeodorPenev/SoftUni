import java.util.HashSet;
import java.util.Scanner;

public class CognateWords {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] words = input.nextLine().split("[\\W]+");
		HashSet<String> hashS = new HashSet<>();
		boolean exist =false;
		for (int i = 0; i < words.length; i++) {
			for (int j = 0 ; j < words.length; j++) {
				if (i==j) {
					continue;
				}
				String temp = words[i]+words[j];
				for (int k = 0; k < words.length; k++) {
					if (temp.equals(words[k])) {
						String format =words[i] +"|"+words[j]+"="+words[k];
						hashS.add(format);
						exist=true;
						break;
					}
				}
				
			}
		}
		if (exist==false) {
			System.out.println("No");
		}
		for (String string : hashS) {
			System.out.println(string);
		}
		
	}
}