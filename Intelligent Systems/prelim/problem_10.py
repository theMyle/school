
inp = [int(x) for x in input().split()]

if (inp[2] == inp[0] + inp[1]):
    print("+")
elif (inp[2] == inp[0] - inp[1]):
    print("-")
elif (inp[2] == inp[0] * inp[1]):
    print("*")
elif (inp[2] == inp[0] / inp[1]):
    print("/")


