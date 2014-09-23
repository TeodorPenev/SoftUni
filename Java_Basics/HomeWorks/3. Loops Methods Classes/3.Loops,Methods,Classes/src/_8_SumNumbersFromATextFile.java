import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class _8_SumNumbersFromATextFile {

	public static void main(String[] args) {
		List<Integer> list = new ArrayList<Integer>();
		File input = new File("input.txt");
		BufferedReader reader = null;
		Integer sum =0;

		try {
		    reader = new BufferedReader(new FileReader(input));
		    String text = null;

		    while ((text = reader.readLine()) != null) {
		        list.add(Integer.parseInt(text));
		    }
		} catch (FileNotFoundException e) {
		    System.out.println("Error");
		} catch (IOException e) {
		    e.printStackTrace();
		} finally {
		    try {
		        if (reader != null) {
		            reader.close();
		        }
		    } catch (IOException e) {
		    }
		}
		for (Integer i:list)
	         sum = sum + i;
		//int sum = list.stream().mapToInt(Integer::intValue).sum();
		System.out.println(sum);
	}

}
