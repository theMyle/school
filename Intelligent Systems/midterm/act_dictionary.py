
print("Record Keeping App\n")

db = {}
user_input = None

while user_input != 'c':
    print("Select an operation:")
    print("\ta. Add Data")
    print("\tb. Delete Data")
    print("\tc. End")
    user_input = input('>> ')

    if user_input.lower() == "a":
        print("\nAdd Data:")
        key = input("\tEnter Key: ")
        val = input("\tEnter Value: ")
        db[key] = val
        print(f"\nResult: {db}\n")

    elif user_input.lower() == "b":
        print("\nDelete Data:")
        key = input("\tEnter Key: ")
        del db[key]
        print(f"\nResult: {db}\n")

print("\nTHANK YOU")


