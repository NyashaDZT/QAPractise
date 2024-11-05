with open ("carSale.csv", 'r', encoding='utf-8-sig') as file:
    lines = file.readlines()

with open ("manufacturers.csv", 'r', encoding='utf-8-sig') as file:
    manufacturers = file.readline().strip()

numbers = [[int(num) for num in line.split(',')] for line in lines]

manufacturer_list = manufacturers.split(',')

for manufacturer in manufacturer_list:
    print(manufacturer)    

for i in range(len(manufacturer_list)):
    print('Manufacturer sold ' + manufacturer_list[i] + ' received £' + str(sum(numbers[i])) + ' in sales.')