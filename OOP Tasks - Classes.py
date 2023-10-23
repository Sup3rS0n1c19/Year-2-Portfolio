class Student:
    def __init__(self, name, student_id, student_class):
        self.name = name
        self.student_id = student_id
        self.student_class = student_class

    def __str__(self):
        return("Hello, my name is (self.name). My student ID is (self.student_id) and I am in class (self.student_class).")

def student():
    student1 = Student("Billy", "M2046274", "Alpha")
    print(student)

student()

def student_data(student):
    print(student.name)
    print(student.student_id)
    print(student.student_class)

student2 = Student("Lenny", "M6472542", "Beta")
student_data(student2)





    
