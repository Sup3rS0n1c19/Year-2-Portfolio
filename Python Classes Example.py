#Classes in Python

class Individual:
    hair = "Brown"
    def __init__(self, name, age):
        self.name = name
        self.age = age

    def myFunction(self):
        print("Greetings, I am " + self.name)

individual1 = Individual("Chara", 20)

print(individual1.name)
print(individual1.age)

individual1.myFunction()

individual2 = Individual("Declan", 17)

individual2.hair = "Blonde"

print(individual2.hair)






