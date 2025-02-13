
sides = [int(x) for x in input("Input three sides of triangle: ").split()]
differentSide = sum(1 for x in range(1, len(sides)) if sides[x] != sides[0])

if differentSide == 0:
    print("This is an Equilateral triangle")
elif differentSide == 1:
    print("This is an Isosceles triangle")
else:
    print("This is an Scalene  triangle")


