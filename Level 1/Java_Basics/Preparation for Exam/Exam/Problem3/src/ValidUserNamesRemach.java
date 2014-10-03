import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ValidUsernames {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String[] names = in.nextLine().replace("\\", " ").split("[/ ()]+");
		String[] check = new String[111];
		String bigOne = "";
		String bigTwo = "";
		int count = 0;
		int max = 0;
		for (int i = 0; i < names.length; i++) {
			Pattern pattern = Pattern.compile("[a-zA-z}][\\w\\d_]+");
			Matcher matcher = pattern.matcher(names[i]);
			while (matcher.find()) {
				check[count] = matcher.group();
				count++;
			}
		}
		for (int i = 0; i < check.length-1; i=i+2) {
			if (check[i]==null) {
				break;
			}
			String first = check[i];
			String second  = check[i+1];
			int sum1 = first.length();
			int sum2 = second.length();
			int sum = sum1+sum2; 
			if (max < sum) {
				max=sum;
				bigOne = check[i];
				bigTwo = check[i+1];
			}
		}
		System.out.printf("%s\n%s",bigOne,bigTwo);
	}
}