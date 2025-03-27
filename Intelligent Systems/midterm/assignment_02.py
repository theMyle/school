
def prompt():
    n1 = int(input('Enter the first integer: '))
    n2 = int(input('Enter the second integer: '))
    print(f"The sum of {n1} and {n2} is {n1+n2}.")
    
    try_again = input("Do you want to try again? ")
    if try_again.lower() == "y":
        return True
    else:
        return False


while prompt():
    continue

print("Thank You")
