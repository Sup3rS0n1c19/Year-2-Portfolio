#Car show room

import csv

def Menu():
    print("1) Add Customer 2) Search")
    global userChoice
    userChoice = int(input("What would you like to do? "))

    if userChoice == 1:
        addCustomer()
    elif userChoice == 2:
        search()
    else:
        print("Please enter either 1 or 2")

def addCustomer():
    global name
    global make
    global colour
    name = input("Please enter the customer's name: ")
    make = input("Please enter the desired car make: ")
    colour = input("Please enter the desired car colour: ")

    description = ("The customer's name is " + name + ", and they're looking for a " + colour + " " + make + ".")
    print(description)

def search():

    print("1) Customer Name \n"
          "2) Car Make \n"
          "3) Car Colour")
    searchChoice = int(input("What would you like to do? "))

    if searchChoice == 1:
        NameSearch()
    elif searchChoice == 2:
        MakeSearch()
    elif searchChoice == 3:
        ColourSearch()
    else:
        print("Please enter 1, 2 or 3: ")

def NameSearch():
    name = input("What is the customer's name? ")

def MakeSearch():
    make = input("What is the desired make? ")

def ColourSearch():
    colour = input("What is the desired colour?")

Menu()

with open('Customers.csv', 'a', newline='') as file:
        writer = csv.writer(file)
        writer.writerow(["Name", "Make", "Colour"])
        writer.writerow([name,make,colour])
