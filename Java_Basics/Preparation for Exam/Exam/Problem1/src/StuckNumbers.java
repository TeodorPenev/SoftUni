import java.util.Scanner;

public class StuckNumbers {

	public static void main(String[] args) {

		Scanner input = new Scanner(System.in);
		int numOfNums = input.nextInt();
		int[] nums = new int[numOfNums];
		boolean exist = false;
		
		for (int i = 0; i < numOfNums; i++) {
			nums[i]=input.nextInt();
		}
		for (int a = 0; a < numOfNums; a++) {
			for (int b = 0; b < numOfNums; b++) {
				for (int c = 0; c < numOfNums; c++) {
					for (int d = 0; d < numOfNums; d++) {
						if (nums[a]!=nums[b] && nums[a]!=nums[c] && nums[a]!=nums[d] && nums[b]!=nums[c] && nums[b]!=nums[d] && nums[c]!=nums[d]) {
							String aB =""+ nums[a] + nums[b]; 
							String cD =""+ nums[c] + nums[d];
							if (aB.equals(cD)) {
								System.out.println(nums[a]+"|"+nums[b]+"=="+nums[c]+"|"+nums[d]);
								exist = true;
							}
						}
					}
				}
			}
		}
		if (exist == false) {
			System.out.println("No");
		}
	}

}