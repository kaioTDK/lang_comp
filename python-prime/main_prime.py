import time
def is_prime(number):
    for i in range(1,number -1,1):
        if number % i == 0 and i != 1:
            return False

    return True

def prime_range(num_span):
    for i in range(1,num_span - 1, 1):
        prime = is_prime(i)
        if prime:
            print(i, " is prime!")


print(is_prime(17))
number = 100



time_start = time.time()
prime_range(number)
time_total = time.time() - time_start
print(f"with {number} iterations took:")
print(f"{time_total}")