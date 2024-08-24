public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		//Prime.testPrime(100000);
		//Quicksort.quicksort(array, 0, array.length - 1);
		for (int i = 0; i < 20;i++){
		int[] array = Quicksort.makeArray(100000);
		Quicksort.testQuick(array);
		}
		//Prime.testPrime(10000);
	}

}
