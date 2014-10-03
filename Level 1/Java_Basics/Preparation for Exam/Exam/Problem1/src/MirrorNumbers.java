import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class MirrorNumbers {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();
		in.nextLine();
		String[] nums = in.nextLine().split(" ");
		String[] revert = new String[nums.length];
		ArrayList<String> exist = new ArrayList<String>();
		ArrayList<String> existRevert = new ArrayList<String>();
		boolean isExist = false;
		for (int i = 0; i < nums.length; i++) {
			String temp = nums[i];
			revert[i] = "" + temp.charAt(3) + temp.charAt(2) + temp.charAt(1)
					+ temp.charAt(0);
		}

		for (int i = 0; i < revert.length; i++) {
			for (int j = i+1; j < revert.length; j++) {
				if (i != j) {
					if (nums[i].equals(revert[j])) {
						isExist = true;
						exist.add(nums[i]);
					}
				}

			}
		}
		int count = 0;
		for (int i = 0; i < exist.size(); i++) {
		String temp =exist.get(i);
		String reverts ="" + temp.charAt(3) + temp.charAt(2) + temp.charAt(1)
				+ temp.charAt(0);
		existRevert.add(reverts);
		}
		if (isExist==true) {
			for (int i = 0; i < exist.size(); i++) {
				System.out.printf("%s<!>%s\n", exist.get(i),
						existRevert.get(i));
				
			}
		}
		else {
			System.out.println("No");
		}
		
	}
}
