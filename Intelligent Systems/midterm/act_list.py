
bank = []

print('Word Bank Program')

while True:
    word = input('Enter the word: ')
    bank.append(word)

    repeat = input('Do you want to try again? ')
    if (repeat.lower() == 'n'):
        break

print(f'\nThe total words inputted by the user is {len(bank)}')
print(bank)


