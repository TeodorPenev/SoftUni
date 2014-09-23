import java.util.Iterator;
import java.util.Scanner;
import java.util.TreeSet;

public class _10_ExtractAllUniqueWords {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		TreeSet<String> alphaSort = new TreeSet<>();
		String[] alpha = input.nextLine().toLowerCase().split("[\\W ]+");
		for (int i = 0; i < alpha.length; i++) {
			alphaSort.add(alpha[i]);
		}
		Iterator<String> iterator = alphaSort.iterator();
		while (iterator.hasNext()) {
			System.out.print(iterator.next().trim() + " ");
		}
	}

}
