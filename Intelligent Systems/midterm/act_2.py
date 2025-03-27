
def reverse_string(string):
    reversed = ""
    for i in string:
        reversed = i + reversed

    print(f"Output: {reversed.upper()} ({len(reversed)} characters)")

reverse_string("Hello World")


