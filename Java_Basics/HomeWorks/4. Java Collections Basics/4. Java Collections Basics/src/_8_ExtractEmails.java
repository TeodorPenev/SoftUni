import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _8_ExtractEmails {

	public static void main(String[] args) {

		Scanner input = new Scanner(System.in);
		String emails = input.nextLine();
        Pattern pattern =Pattern.compile("([\\d\\w._-]+)([@])(([\\w])+(.)([\\w-])+)([.])([\\w]+)");
        Matcher match =pattern.matcher(emails);
      while(match.find()){
    	  System.out.println(match.group());
      }
	}
}
