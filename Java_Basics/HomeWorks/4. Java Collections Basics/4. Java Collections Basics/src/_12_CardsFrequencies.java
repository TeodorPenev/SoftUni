import java.util.HashMap;
import java.util.Scanner;

public class _12_CardsFrequencies {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);//"\u2665 \u2666 \u2663 \u2660"
String[] facesArr = input.nextLine().replace("\u2660","").replace("\u2663","").replace("\u2665","").replace("\u2666","").split(" ");

	HashMap<String,Integer> hashMArr =new HashMap<>();
	
	for (String string : facesArr) {
		hashMArr.put(string,0);
	}
	for (int i = 0; i < facesArr.length; i++) {
		Integer count = hashMArr.get(facesArr[i]); {
			count++;
			hashMArr.put(facesArr[i],count);
		}
	}
	double n =facesArr.length;
	for (String key : hashMArr.keySet()) {
		double appereances =hashMArr.get(key);
		System.out.printf("%s -> %.2f%%\n",key,(appereances/n)*100);
	}
	}
}
