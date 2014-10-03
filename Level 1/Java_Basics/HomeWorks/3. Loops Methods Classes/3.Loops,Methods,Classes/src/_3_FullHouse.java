public class _3_FullHouse {
	public static void main(String[] args) {
		String[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J",
				"Q", "K", "A" };
		char[] suits = { '♣', '♦', '♥', '♠' };
		int counter = 0;
		for (int i = 0; i < 13; i++) {
			for (int j = 0; j < 13; j++) {
				if (i != j) {

					for (int first = 0; first < 4; first++) {
						for (int second = first + 1; second < 4; second++) {
							for (int third = second + 1; third < 4; third++) {
								for (int fourth = 0; fourth < 4; fourth++) {
									for (int fifth = fourth + 1; fifth < 4; fifth++) {
										counter++;
										System.out.println(cards[i] + ""
												+ suits[first] + ""
												+ cards[i] + ""
												+ suits[second] + ""
												+ cards[i] + ""
												+ suits[third] + ""
												+ cards[j] + ""
												+ suits[fourth] + ""
												+ cards[j] + ""
												+ suits[fifth] + " ");
									}
								}
							}
						}
					}

				}

			}
		}
		System.out.println(counter);
	}
}