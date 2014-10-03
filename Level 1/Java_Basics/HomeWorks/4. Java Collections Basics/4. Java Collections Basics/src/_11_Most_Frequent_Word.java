import java.util.Scanner;
import java.util.Set;
import java.util.TreeMap;
import java.util.TreeSet;

public class _11_Most_Frequent_Word {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] wordsStr = input.nextLine().toLowerCase().split("[\\W]+");
		TreeMap<String, Integer> words = new TreeMap<String, Integer>();
		int counter = 0;
		int max = Integer.MIN_VALUE;
		String result = "";

		for (int i = 0; i < wordsStr.length; i++) {
			if (words.get(wordsStr[i]) == null) {
				words.put(wordsStr[i], 0);
			}
			Integer count = words.get(wordsStr[i]);
			count++;
			words.put(wordsStr[i], count);
			if (max < count) {
				max = count;
			}
		}

		TreeSet<String> sort = new TreeSet<String>();

		for (int i = 0; i < wordsStr.length; i++) {
			sort.add(wordsStr[i]);
		}

		for (String string : sort) {
			if (words.get(string) == max) {
				System.out.printf("%s -> %d times \n", string, max);
			}
		}

	}

}
