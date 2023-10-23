#Lists Revision

def accessingElements():
    my_list = ['p','r','o','b','e']

    #Output: p
    print(my_list[0])

    #Output: o
    print(my_list[2])

    #Output: e
    print(my_list[4])

accessingElements()

def negativeIndexing():
    my_list = ['p','r','o','b','e']

    #Output: e
    print(my_list[-1])

    #Output: p
    print(my_list[-5])

negativeIndexing()

def sliceList():
    my_list = ['p','r','o','g','r','a','m','i','z']

    #Elements, 3rd to 5th
    print(my_list[2:5])

    #Elements, Beginning to 4th
    print(my_list[:-5])

    #Elements, 6th to end
    print(my_list[5:])

    #Elements, Beginning to end
    print(my_list[:])

sliceList()

def changeOrAddElements():

    #Mistake Values
    odd = [2, 4, 6, 8]

    #Change the first item
    odd[0] = 1

    #Output: [1, 4, 6, 8]
    print(odd)

    #Change 2nd to 4th items
    odd[1:4] = [3, 5, 7]

    #Output: [1, 3, 5, 7]
    print(odd)

changeOrAddElements()

def appendingLists():
    odd = [1, 3, 5]

    odd.append(7)

    #Output: [1, 3, 5, 7]
    print(odd)

    odd.extend([9, 11, 13])

    #Output: [1, 3, 5, 7, 9, 11, 13]
    print(odd)

appendingLists()

def deletingElements():
    my_list = ['p','r','o','b','l','e','m']

    #Delete one item
    del my_list[2]

    #Output: ['p','r','b','l','e','m']
    print(my_list)

    #Delete multiple items
    del my_list[1:5]

    #Output: ['p','m']
    print(my_list)

    #Delete entire list
    del my_list

    #Error: List not defined
    #print(my_list)

deletingElements()


    
