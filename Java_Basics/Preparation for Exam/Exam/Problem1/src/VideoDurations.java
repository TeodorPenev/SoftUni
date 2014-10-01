import java.util.Scanner;

public class VideoDurations {

	public static void main(String[] args) {

		Scanner input = new Scanner(System.in);
		String inputs = "";
		String[] format = new String[999];
		int hours = 0;
		int minutes = 0;
		for (int i = 0; i <999; i++) {
			inputs += " " + input.next().replace(":", " ");
			if (input.hasNext("End")) {
				break;
			}
		}
		format = inputs.split(" ");
		
		for (int i = 1; i < format.length; i = i + 2) {
			hours = hours + Integer.parseInt(format[i]);
			minutes = minutes + Integer.parseInt(format[i + 1]);
		}
		
		if (minutes >= 60) {
			hours = hours + minutes / 60;
			minutes = minutes % 60;
		}
		
		if (minutes<10) {
			System.out.printf("%d:0%d",hours,minutes);
		}
		else {
			System.out.printf("%d:%d",hours,minutes);
		}
		
	}
}