import time
def is_prime(number):
    i = 1
    while i < number:
        if number % i == 0 and i != 1:
            return False
        i = i+1
    return True
       

def prime_range(num_span):
    i = 1
    while i < num_span:
        prime = is_prime(i)
        #if prime:
        #    print(i, " is prime!")
            #continue
        i = i+1

number = 10000

time_start = time.time()
prime_range(number)
time_total = time.time() - time_start
print(f"with {number} iterations took:")
print(f"{time_total:0f}s")
print(f"{time_total*1000:4f}ms")