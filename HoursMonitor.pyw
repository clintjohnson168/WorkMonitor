'''
This is a class that will help verify hours worked for a given week
'''

class HoursWorked:
    MONSUN = "MondaySunday"
    SUNSAT = "SundaySaturday"
    
    def __init__(self, fileName):
        self.saveFile = fileName
        self.records = {}
        self.workWeek = ""
        self.getInfo()

    def __init__(self, fileName, workweek):
        self.saveFile = fileName
        self.records = {}
        self.workWeek = workweek

    def getFileName(self):
        return self.saveFile

    def setWorkWeek(self, workWeek):
        self.workWeek = workWeek
    
    def getInfo(self):
        try:
            #import info from file
            with open(self.saveFile, 'r') as file:
                for line in file:
                    words = input.split('^')
                    date = words[0]
                    clockIn = words[1]
                    clockOut = words[2]
                    lunch = words[3]
                    self.records[date] = [clockIn, clockOut, lunch]
        except(FileNotFoundError):
            #ignore no file error
            print("File not found.")
            pass

    def add(self, date, clockIn, clockOut, lunchMin):
        self.records[date] = [clockIn, clockOut, lunchMin]
        self.save()

    def save(self):
        try:
            #overrite file with empty content
            file = open(self.saveFile, 'w')
            file.write("")
            file.close()
            #append priority list with all items
            with open(self.saveFile, "a") as file:
                #write myList to file
                for item, values in self.records.items():
                    file.write("%s-%s-%s-%s\n" %(item, values[0], values[1], values[2]))
            print("List has been updated and saved")
        except Exception as ex:
            #do noting
            print(repr(ex))
            pass
