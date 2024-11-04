# # import math

# # number = 1
# # factorial = 1
# # user_input = input('What number would you like a factorial for: ')
# # user_input = int(user_input)

# # # while (n < 100):
# # #     print(n * n)
# # #     n = n + 1

# # while(user_input > 1):
# #     number *= user_input 
# #     user_input = user_input - 1

# # print(number)

# # Investment:
# # banked_amount = 100
# # years = 0


# # while (banked_amount < 1000):
# #     interest = banked_amount * 0.10
# #     banked_amount += interest
# #     years += 1

# #print(years)

# ages = [12,18,33,84,45,67,12,82,95,16,10,23,43,29,40,34,30,16,44,69,70,74,38,65,36,83,50,11,79,64,78,37,3,8,68,22,4,60,33,82,45,23,5,18,28,99,17,81,14,88,50,19,59,7,44,93,35,72,25,63,11,69,11,76,10,60,30,14,21,82,47,6,21,88,46,78,92,48,36,28,51]
# ages_two = []
# age_length = len(ages)
# i = 0

# for age in ages:
#     age += 1
#     ages_two.append(age)

# print(ages_two)
# print(' ')

# while i < len(ages_two):
#     if ages_two[i] < 16 or ages_two[i] > 65:
#         del ages_two[i]
#     else:
#         i += 1

# print(ages_two)

# ages_two.sort()

# print(ages_two)
# print(' ')

# ages_two_len = len(ages_two)

# print(ages_two_len)

vowels = ['a', 'e', 'i', 'o', 'u']

word = 'hello'
vowel_count = 0

for letter in word:
    if letter == 'a' or letter == 'e' or letter == 'i' or letter == 'u' or letter == 'o':
        vowel_count += 1

print(vowel_count)        




