from abc import ABC, abstractmethod

class Bird(ABC):
    def __init__(self, name):
        self.name = name

    @abstractmethod
    def do_sound(self) -> str:
        pass


class FlyingBird(Bird):
    @abstractmethod
    def fly(self):
        pass


class RunningBird(Bird):
    @abstractmethod
    def run(self):
        pass


class Eagle(FlyingBird):
    def fly(self):
        print(f"{self.name} is flying high and fast!")

    def do_sound(self) -> str:
        return "Screech!"


class Geococcyx(RunningBird, FlyingBird):
    def fly(self):
        print(f"{self.name} is flying low")

    def run(self):
        print(f"{self.name} runs in the cannon")

    def do_sound(self) -> str:
        return "Bip, bip"

if __name__ == '__main__':
    roadWalker = Geococcyx("CorreCamino")
    roadWalker.fly()
    roadWalker.run()
    print(roadWalker.do_sound())

    baldEagle = Eagle("Falcon")
    baldEagle.fly()
    print(baldEagle.do_sound())
