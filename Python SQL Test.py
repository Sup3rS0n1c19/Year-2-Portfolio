import sqlite3

connection = sqlite3.connect("aquarium.db")

cursor = connection.cursor()

#Creating the table
#cursor.execute("CREATE TABLE fish (name TEXT, species TEXT, tank_number INTEGER)")

#Inserting values into the table
cursor.execute("INSERT INTO fish VALUES ('Sammy', 'Shark', 1)")
cursor.execute("INSERT INTO fish VALUES ('Jamie', 'Cuttlefish', 7)")

def Inserting_Data():
    name1 = input("Enter the fish's name: ")
    species1 = input("Enter the fish species: ")
    tank_number1 = input("Enter the tank number: ")

    cursor.execute("INSERT INTO fish (name,species,tank_number) VALUES (?,?,?)",(name1, species1, tank_number1))
Inserting_Data()

#Fetching the data
rows = cursor.execute("SELECT name, species, tank_number FROM fish").fetchall()
cursor.close

#Displaying the data
print(rows)

def Database_Search():
    target_fish_name = input("Please enter the name of the fish: ")
    rows = cursor.execute(
        "SELECT name, species, tank_number FROM fish WHERE name =?",(target_fish_name,),
        ).fetchall()

    print(rows)

Database_Search()
