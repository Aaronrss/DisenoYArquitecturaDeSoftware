from abc import ABC, abstractmethod

# person o personstorage
class Person(ABC):
    @abstractmethod
    def id(self, name, surname):
        pass

class PersonDB(Person):
    def id(self, name, surname):
        print(f'|Name|Surname|\n|{name}|{surname}|')

class PersonJSON(Person):
    def id(self, name, surname):
        print(f'{{\n\t"name": "{name}",\n\t"surname": "{surname}"\n}}')
    
class PersonXML(Person):
    def id(self, name, surname):
        print(f'<?xml version="1.0?>\n<Person>\n\t<Name>\n\t\t{name}\n\t</Name>\n\t<Surname>\n\t\t{surname}\n\t</Surname>\n</Person>')

class PersonalInfo:
    def __init__(self, name, surname, gender, age):
        self.name = name
        self.surname = surname
        self.gender = gender
        self.age = age

class PersonStorage:
    def __init__(self, person, personalInfo):
        self.person = person
        self.personalInfo = personalInfo

    def call(self, name):
        if isinstance(self.person, PersonDB):
            self.person.id(name, self.personalInfo.surname)
        elif isinstance(self.person, PersonJSON):
            self.person.id(name, self.personalInfo.gender)
        elif isinstance(self.person, PersonXML):
            self.person.id(name, self.personalInfo.age)     
        else:
            raise Exception ('No hay persona que devolver. ')

if __name__ == '__main__':
    personaA = PersonalInfo("Aaron", "Rosas", "H", 25)
    p_storage = PersonStorage(PersonJSON(), personaA)
    p_storage.call("Hola => a ")