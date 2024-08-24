import java.time.Duration;
import java.time.Instant;
import java.util.Random;

public class Quicksort {
	private static final int partition(int[] array, int start, int end) {
		int i = start - 1;
		int pivot = array[end];

		for (int j = start; j < end; j++) {
			if ( array[j] < pivot) {
				i++;
				int temp = array[i];
				array[i] = array[j];
				array[j] = temp;
			}
		}
		i++;
		int temp = array[i];
		array[i] = array[end];
		array[end] = temp;

		return i;
	}
	public static final void quicksort(int[] array, int start, int end) {

		if (end <= start) {
			return;
		}

		int i = partition(array, start, end);

		quicksort(array, start, i - 1);
		quicksort(array, i + 1, end);

	}
	public static void testQuick(int[] array) {
		Instant start = Instant.now();
		quicksort(array, 0, array.length - 1);
		Instant end = Instant.now();
		Duration total = Duration.between(start, end);
		System.out.println(total.toMillis()+"ms");
		System.out.println(total.getNano()+"ns");
	}
	public static int[] makeArray(int lenght){
		int[] array = new int[lenght];
		Random rand = new Random();

		try {
			for (int i = 0; i < lenght; i++){
				array[i] = rand.nextInt(0, lenght);
			}
		}
		catch (Exception e) {
			throw e;
		}
		return array;
	}
}
