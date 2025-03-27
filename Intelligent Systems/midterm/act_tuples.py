
def calculateProduct(tuple):
    product = 1
    for i in tuple:
        product *= i
    return product

print(calculateProduct((4,3,2,2,-1,18)))
print(calculateProduct((2,4,8,8,3,2,9)))


