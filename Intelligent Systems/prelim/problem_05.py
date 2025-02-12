
caloriesPerServing = int(input("Enter the Calories per Serving: "))
gramsOfFatPerServing = int(input("Enter the grams of Fat per Serving: "))
totalCal = gramsOfFatPerServing * 9 / caloriesPerServing * 100
status = "exceed" if totalCal > 30 else "meet"
print("Contains {:.2f}% calories from fat, and {} the AHA recommendation.".format(totalCal, status)) 
