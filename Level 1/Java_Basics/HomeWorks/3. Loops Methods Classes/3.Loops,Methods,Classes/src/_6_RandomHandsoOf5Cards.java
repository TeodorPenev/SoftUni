import java.util.Random;
import java.util.Scanner;
 
 
public class _6_RandomHandsoOf5Cards {
 
        public static void main(String[] args) {
                Scanner sc = new Scanner (System.in);
                System.out.println("Enter the count of hands");
                int hands = sc.nextInt();
                String[]  cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
                char[] patterns = {'♣', '♦', '♥', '♠'};
                boolean[] isCardUsed = new boolean[13];
                boolean[] isPatternUsed = new boolean[4];
                for (int i = 0; i < hands; i++) {
                        for (int j = 0; j < 5; j++) {
                                Random r = new Random();
                                int card;
                                int pattern;
                                do {
                                        card = r.nextInt(13);
                                        pattern = r.nextInt(4);
                                        if (!( isCardUsed[card] && isPatternUsed[pattern])) {
                                                System.out.print(cards[card] + "" + patterns[pattern] + " ");
                                                isCardUsed[card] = true;
                                                isPatternUsed[pattern] = true;
                                                break;
                                        }
                                }
                                while(true); 
                        }
                        System.out.println();
                        for (int k = 0; k < isCardUsed.length; k++) {
                        	isCardUsed[k] = false;
							
						}
                        for (int l = 0; l < isPatternUsed.length; l++) {
                        	isPatternUsed[l] = false;
							
						}
                        
                }
 
        }
 
}