from HoursMonitor import HoursWorked
import datetime

'''
main program that uses the HoursWorked class
'''

def menu():
    print("\n*****************************")
    print("*                           *")
    print("*  1)  Add Today's Time     *")
    print("*  2)  Add Record           *")
    #print("*  2)  View Work Week       *")
    #print("*  3)  Update Ratings       *")
    #print("*  4)  Update Item          *")
    #print("*  5)  Remove Item          *")
    print("*                           *")
    print("*  10) Close Program        *")
    print("*                           *")
    print("*****************************\n")
    
def main():
    #create class object
    schedule = HoursWorked("hours.etxt", HoursWorked.MONSUN)

    while True:
        menu()
        choice = 0
        try:
            choice = int(input("Enter you choice: "))
        except Exception:
            #ignore invalid inputs
            pass

        if choice == 1:
            date = datetime.datetime.now()
            dateStr = "%s/%s/%s" %(date.year, date.month, date.day)
            inString = str(raw_input("Enter clocked in as 'HH:MM': "))
            clockIn = datetime.datetime.strptime(inString, '%H:%M')
            clockInStr = "%s:%s" %(clockIn.hour, clockIn.min)
            inString = str(raw_input("Enter clocked out as 'HH:MM': "))
            clockOut = datetime.datetime.strptime(inString, '%H:%M')
            inString = str(raw_input("Enter in you lunch break in min: "))
            lunchBreak = int(inString)
            print("Date: %s, In: %s, Out %s, Lunch %s" %(dateStr, clockInStr,
                                                         clockOut, lunchBreak))
        elif choice == 2:
            inString = str(raw_input("Enter date in 'YYYY:mm:dd': "))
            date = datetime.datetime.strptime(inString, '%Y, %m, %d')
            inString = str(raw_input("Enter clocked in as 'HH:MM': "))
            clockIn = datetime.datetime.strptime(inString, '%H:%M:%S')
            inString = str(raw_input("Enter clocked out as 'HH:MM': "))
            inString = str(raw_input("Enter in you lunch break in min: "))
            lunchBreak = int(inString)
            print("Date: %s, In: %s, Out %s, Lunch %s" %(date, clockIn,
                                                         clockOut, lunchBreak))

        elif choice == 10:
            print("Closing program.....")
            break

main()
