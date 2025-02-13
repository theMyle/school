name = input("Enter your name: ")
math = float(input("Enter math grade: "))
english = float(input("Enter english grade: "))
science = float(input("Enter science grade: "))

# Variable declarations
ave = (math+science+english)/3
status = None
list_of_failed_subjs = []

# Check for failed semester
if ave >= 75:
    status = "Passed"
else:
    status = "Failed"

# Check for failed subj
if english < 75:
    list_of_failed_subjs.append("English")
if math < 75:
    list_of_failed_subjs.append("Math")
if science < 75:
    list_of_failed_subjs.append("Science")

# Summary
print("\nName:", name)
print("Math:", math)
print("English:", english)
print("Science:", science)
print("Average:", ave)

if status == "Passed":
    print("\nCongratulations! You passed the semester")

    # check for failed subjs
    if len(list_of_failed_subjs) != 0:
        print("But you need to re-enroll:")
        
        for subject_name in list_of_failed_subjs:
            print(subject_name, "subject")
else:
    print("Sorry you failed the semester")


