print ("Hi,")
print ("Name your shoping list")
a = input()

print ("Enter your first product")
b = input()

print("Quantity fo your product")
c = input()

print("Enter your second product")
d = input()

print ("Quantity of ur second product")
e = input()

finalorder = '''Hi,
Here is ur product list :D'''
print(finalorder)

nowfinalorder = "You want {} pieces of {} "
secondorderlist = "Your second product is {} and your want {} pieces of {} "
print(nowfinalorder.format(c, b))
print(secondorderlist.format(d, e, d))