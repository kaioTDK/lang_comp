import time
def is_prime(number):
    if not isinstance(number,int):
        return "not a number!"
    for i in range(1,number -1,1):
        if number % i == 0 and i != 1:
            return False

    return True

def prime_range(num_span):
    if not isinstance(number,int):
        return "not a number!"
    for i in range(1,num_span - 1, 1):
        prime = is_prime(i)

number = 100000

time_start = time.time()
prime_range(number)
time_total = time.time() - time_start
print(f"with {number} iterations took:")
print(f"{time_total}s")
print(f"{time_total*1000:4f}ms")