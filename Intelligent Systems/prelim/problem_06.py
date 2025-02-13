
calendar = [
    ["Orange", 1,8,15,22,29],
    ["Yellow", 2,9,16,23,30],
    ["Red", 3,10,17,24,31],
    ["Violet", 4,11,18,25],
    ["Blue", 5,12,19,26],
    ["Black", 6,13,20,27],
    ["Green", 7,14,21,28]
]

x = 0
while x != -999:
    x = int(input("Enter the day of Month: "))
    if x>=1 and x<=31:
        for day in calendar:
            if x in day:
                print(day[0])


