#Importing the module
import sqlite3

connection = sqlite3.connect("contactBook.db")

cursor = connection.cursor()

#Creating the table
#cursor.execute("CREATE TABLE contact (contactID INTEGER, firstName TEXT, lastName TEXT, phoneNumber TEXT, email TEXT)")
#cursor.execute("CREATE TABLE address (addressID INTEGER, houseNumber INTEGER, streetName TEXT, town TEXT, country TEXT, postcode TEXT, contactID INTEGER)")


#Function #1 - Adding a contact to the database
def addContact():
    print("\n")
    contactID = int(input("Enter the contact ID: "))
    firstName = input("Enter the contact's first name: ")
    lastName = input("Enter the contact's last name: ")
    phoneNumber = input("Enter the contact's phone number: ")
    email = input("Enter the contact's email address: ")

   #Inserting the data into the contact table
    cursor.execute("INSERT INTO contact(contactID,firstName,lastName,phoneNumber,email) VALUES (?,?,?,?,?)", (contactID, firstName, lastName, phoneNumber, email))

    menu()
    
#Function #2 - Adding an address to the database
def addAddress():
    print("\n")
    addressID = int(input("Enter the address ID: "))
    houseNumber = int(input("Enter the house number: "))
    streetName = input("Enter the street name: ")
    town = input("Enter the town: ")
    country = input("Enter the country")
    contactID = int(input("Enter the contact ID: "))

    #Inserting the data into the address table
    cursor.execute("INSERT INTO address(addressID,houseNumber,streetName,town,country,contactID) VALUES (?,?,?,?,?,?)", (addressID, houseNumber, streetName, town, country, contactID))

    menu()

#Function #3 - Search for contacts via name
def searchContact():
    print("\n")
    
    target_first_name = input("Please enter the first name of the contact: ")
    rows = cursor.execute(
        "SELECT contactID, firstName, lastName, phoneNumber, email FROM contact WHERE name =?",(target_first_name,),
        ).fetchall()
    
    print(rows)

    menu()

#Function #4 - Display all contact records
def displayContact():

    print("\n")
    #Fetching the data
    rows = cursor.execute("SELECT contactID, firstName, lastName, phoneNumber, email FROM contact").fetchall()
    cursor.close

    #Displaying the data
    print(rows)

    menu()

#Function #5 - Delete contact records
def deleteContact():
    print("\n")
    confirmDelete = input("Please enter the ID of the contact you wish to delete")
    rows = cursor.execute("DELETE FROM contact WHERE contactID = " + confirmDelete)
    connection.commit()

    menu()
    

#Function #6 - Modify contact records
#def modifyContact():
    #selectContact = int(input("Please select the ID of the cont"

#Defining a menu for the system
def menu():
    print("\n")
    print(" 1) Add contact \n 2) Add address \n 3) Search \n 4) Display records \n 5) Delete records \n 6) Modify records ")
    option = int(input("Please select a number between 1 and 6: "))
    if option == 1:
        addContact()
    elif option == 2:
        addAddress()
    elif option == 3:
        searchContact()
    elif option == 4:
        displayContact()
    elif option == 5:
        deleteContact()
    elif option == 6:
        modifyContact()

menu()
        
