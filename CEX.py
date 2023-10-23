import sqlite3

connection = sqlite3.connect("CEX.db")

cursor = connection.cursor()

#Creating the table
cursor.execute("CREATE TABLE game (name TEXT, price FLOAT, game_id INTEGER)")

#Inserting values into the table
cursor.execute("INSERT INTO game VALUES ('Sonic Generations', 15.00, 1)")
cursor.execute("INSERT INTO game VALUES ('Dead By Daylight', 20.00, 2)")
cursor.execute("INSERT INTO game VALUES ('Monopoly Plus', 10.00, 3)")
cursor.execute("INSERT INTO game VALUES ('Minecraft', 30.00, 4)")

def Inserting_Data():
    name1 = input("Enter the game's name: ")
    price1 = input("Enter the price: ")
    game_id1 = input("Enter the id: ")

    cursor.execute("INSERT INTO game (name,price,game_id) VALUES (?,?,?)", (name1, price1, game_id1))

def Display_Data():
    #Fetching the data
    rows = cursor.execute("SELECT name, price, game_id FROM game").fetchall()
    cursor.close

    #Displaying the data
    print(rows)

Display_Data()
def Database_Name_Search():
    target_game_name = input("Please enter the name of the game ")
    rows = cursor.execute(
        "SELECT name, price, game_id FROM game WHERE name =?",(target_game_name,),
        ).fetchall()

    print(rows)

def Menu():
    print("1) Inserting data into the data into the database)
    print("2) Displaying data from the database")
    print("3) Searching the database by name")

    userChoice = int(input("Choose an option: ")
    while userChoice > 0 and userChoice <6:
        if userChoice == 1:
            InsertingData()
        if userChoice == 2:
            Display_Data()
        if userchoice == 3:
            Database_Name_Search()
        if userChoice == 4:
            Database_Price_Search()
        if userChoice == 5:
            Database_Price_Search()
        
                           
    
