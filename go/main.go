package main

import "time"

func is_prime(number int) bool {
	for i := 2; i < number; i++ {
		if number%i == 0 {
			return false
		}
	}
	return true
}

func is_prime_span(number int) {
	for i := 2; i < number; i++ {
		prime := is_prime(i)
		if prime {
			print("")
		}
	}
}

func test() {
	start := time.Now().Nanosecond()
	is_prime_span(10000)
	end := time.Now().Nanosecond()
	time_elapsed := end - start
	println(time_elapsed / 1000000)
}
func main() {

	for i := 0; i < 10; i++ {
		test()
	}
}
