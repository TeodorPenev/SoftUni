import java.util.ArrayList;
import java.util.Scanner;


public class _9_CombineListsOfLetters {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String firstInput = input.nextLine().replace(" ","");
		String secondInput = input.nextLine().replace(" ","");
        ArrayList<Character> letters1 = new ArrayList<>();
        ArrayList<Character> letters2 = new ArrayList<>();
        for (int i = 0; i < firstInput.length(); i++) {
			letters1.add(firstInput.charAt(i));
		}
        for (int i = 0; i < secondInput.length(); i++) {
			letters2.add(secondInput.charAt(i));
		}
        for (int i = 0; i < letters2.size(); i++) {
        	for (int j = 0; j < letters1.size(); j++) {
        		if (letters2.get(i).equals(letters1.get(j))) {
    				letters2.remove(i);
    				i--;
    				break;
    			}
			}
		}
        for (int i = 0; i < letters2.size(); i++) {
			letters1.add(letters2.get(i));
		}
        for (int i = 0; i < letters1.size(); i++) {
			System.out.printf("%s ",letters1.get(i));
		}
        
	}

}
