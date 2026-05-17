# Author: Faith Makawure
# Dynamic Arrays

def multiples_of(start, count):
    """Return a list containing the first count multiples of start."""
    multiples = [0.0] * count
    for i in range(count):
        multiples[i] = start * (i + 1)
    return multiples


def main():
    result = multiples_of(3, 5)
    for number in result:
        print(number, end=" ")


if __name__ == "__main__":
    main()
        