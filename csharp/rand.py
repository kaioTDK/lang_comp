import random

def generate_unique_numbers(count):
  """Generates a list of unique random numbers.

  Args:
    count: The number of unique numbers to generate.

  Returns:
    A list of unique random numbers.
  """

  numbers = set()
  while len(numbers) < count:
    numbers.add(random.randint(0, 10001))  # Adjust range as needed
  return list(numbers)

if __name__ == "__main__":
  unique_numbers = generate_unique_numbers(10000)
  print(unique_numbers)