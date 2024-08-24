import java.time.Duration;
import java.time.Instant;

public class Prime {
	private static final boolean isPrime(int num) {
		for (int i = 2; i < num; i++) {
			if (num % i == 0) {
				return false;
			}
		}
		return true;
	}
	private static final int[] isPrime_Span(int num){
		int[] array = new int[num];
		for (int i = 1; i <= num; i++) {
			if (isPrime(i)) {
				array[i - 1] = i;
			}
		}
		return array;
	}

	public static void testPrime(int num) {
	 Instant start = Instant.now();
	 isPrime_Span(num);
	 Instant end = Instant.now();
	 Duration total = Duration.between(start, end);
	 System.out.println(total.toMillis());
	}
}