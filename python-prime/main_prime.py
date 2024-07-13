
def is_prime(number):
    for i in range(1,number -1,1):
        if number % i == 0 and i != 1:
            return False

    return True

print(is_prime(17))