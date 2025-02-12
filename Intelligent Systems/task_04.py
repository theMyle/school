
name = input("Employee Name: ")
hours = float(input("Enter number of hours: "))
sss = float(input("SSS contribution: "))
phil_health = float(input("Phil health: "))
housing_loan = float(input("Housing loan: "))

rate = 500
tax = 500
gross_pay = hours * tax
total_deductions = tax + sss + phil_health + housing_loan
net_salary = gross_pay - total_deductions

# Output 
print("\n==================PAYSLIP======================")
print("=============EMPLOYEE INFORMATION==============")

print(f"Emplyee Name: {name.upper()}")
print(f"Rendered Hours: {hours}")
print(f"Rate per Hour: {rate}")
print(f"Gross Salary: {hours * rate}")

print("==================DEDUCTIONS===================")
print(f"SSS: {sss}")
print(f"PhilHealth: {phil_health}")
print(f"Other Loan: {housing_loan}")
print(f"Tax: {tax}")
print(f"Total Deductions: {total_deductions}")
print(f"\nNet Salary:PHP {net_salary}")


