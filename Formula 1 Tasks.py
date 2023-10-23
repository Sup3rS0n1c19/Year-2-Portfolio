def F1_Tasks():
    #Formula 1 Teams
    Teams = ["Ferrari", "Williams", "Haas", "Racing Point"]

    #Task 1
    print("Current bonus payment: ", Teams[0])

    #Task 2
    print(Teams[0], "'s rival is: ", Teams[1])

    #Task 3
    Teams[3] = "Aston Martin"
    

    #Task 4
    Teams.append("Red Bull")

    Teams.append("McLaren")

    print(Teams)

    #Task 5
    replaceTeam = int(input("Please select a number between 0 and 5: "))
    newTeamName = input("Please select a new team name: ")

    if replaceTeam == 0:
        Teams[0] = newTeamName
    if replaceTeam == 1:
        Teams[1] = newTeamName
    if replaceTeam == 2:
        Teams[2] = newTeamName
    if replaceTeam == 3:
        Teams[3] = newTeamName
    if replaceTeam == 4:
        Teams[4] = newTeamName
    if replaceTeam == 5:
        Teams[5] = newTeamName

    print(Teams)

    #Task 6
    Driver = ["Sebastian Vettel", "Charles Leclerc", "Kevin Magnussen", "Lando Norris"]
    Wages = [21, 17, 3, 5]


F1_Tasks()


