import statistics

data="100,30,53,67,85,87,50,45,51,72,64,69,59,17,22,23,44,25,16,67,85,87,50,45,51,72,59,14,50,55,32,23,24,25,37,28,39,30,33,35,40,34,41,43,94,95,59,98,99,44,45,47,48,49,53,61,63,69,75,77,60,83"
grades = data.split(',')

print(grades)
grades = list(map(int, grades))

min_grade = min(grades)
print(min_grade)

max_grade = max(grades)
print(max_grade)

average = sum(grades) / len(grades)
rounded_avg = round(average, 2)
print(average)
print(rounded_avg)

mean = round(statistics.mean(grades))
print(mean)

median = statistics.median(grades)
print(median)