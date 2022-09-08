# Ejemplo de principio de responsabilidad
# La clase solo puede ocupar las funciones que existen en ella.

class Auto:
    def __init__(self,name):
        self.name = name
    
    def __repr__(self):
        return f'(name= {self.name})'

    @classmethod
    def save(cls, Auto):
        print(f'El auto se guardó {Auto} en la BD')
 
if __name__ == '__main__':
    #INSTANCIANDO
    a = Auto('Kia')
    Auto.save(a)
    print(a.name)