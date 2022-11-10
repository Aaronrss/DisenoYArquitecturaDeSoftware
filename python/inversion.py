class Engine(object):
    def __init__(self):
        pass

    def accelerate(self):
        pass

    def getRPM(self):
        currentRPM = 0
        #...
        return currentRPM

class Vehicle(object):
    def __init__(self):
        self._engine = Engine()

    def getEngineRPM(self):
        return self._engine.getRPM()

if __name__ == '__main__':
    ferrari = Vehicle()
    print(ferrari.getEngineRPM())

