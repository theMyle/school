
inp = [int(x) for x in input().split()]
if inp[2] >= 3 and inp[2] <= 20:
    while inp[2] != 0:
        print(f"{inp[0]}", end=" ")
        inp[0] += inp[1]
        inp[2] -= 1
