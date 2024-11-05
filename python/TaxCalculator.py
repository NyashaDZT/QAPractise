tax_paid = 0

def getIncomeTax(salary):
    if salary > 150000:
        tax_paid = salary * 0.45
        tax_paid = str(tax_paid)
        return 'You paid ' + tax_paid + ' on your salary.'
    elif salary > 34501:
        tax_paid = salary * 0.4
        tax_paid = str(tax_paid)
        return 'You paid ' + tax_paid + ' on your salary.'
    elif salary > 11850:
        tax_paid = salary * 0.20
        tax_paid = str(tax_paid)
        return 'You paid ' + tax_paid + ' on your salary.'
    else:
        return 'Salary is below the taxable limit.'

print(getIncomeTax(75000))