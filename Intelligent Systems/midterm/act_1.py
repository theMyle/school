
def calculateStudentGrade(name, math, english, science):
    average = (math + english + science)/ 3
    print(f"{name}'s grade (Math={math}, Science={science}, English={english}) and the average is {average:.2f}")

calculateStudentGrade('John', 100, 100, 90)
calculateStudentGrade('Ana', 95, 95, 95)
calculateStudentGrade('Frank', 80, 80, 80)

