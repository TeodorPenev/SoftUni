import java.util.Scanner;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

import org.joda.time.DateTime;
import org.joda.time.Days;

public class _7_DaysBetweenTwoDates {
	public static void main(String[] args) throws ParseException {
		Scanner input = new Scanner(System.in);
		String first = input.nextLine();
		String second = input.nextLine();
		SimpleDateFormat format = new SimpleDateFormat("d-M-yyyy");
		Date d1 = null;
		Date d2 = null;

		d1 = format.parse(first);
		d2 = format.parse(second);

		DateTime dt1 = new DateTime(d1);
		DateTime dt2 = new DateTime(d2);
		System.out.print(Days.daysBetween(dt1, dt2).getDays());

	}
}
