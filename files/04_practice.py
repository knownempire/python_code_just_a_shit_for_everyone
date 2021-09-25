# a = ("hi")
# print (a) 
# b = input("enter your name")
# c = " how are you "
 
# print (a+b+c)


Letter = '''Dear <|Name|>,
You are selected!

Date: <|Date|> 
'''
name = input("enter your name\n")
name = input("Enter date\n")
Letter = Letter.replace("<|Name|>",name)
Letter = Letter.replace ("<|Date|>",)
print (Letter)