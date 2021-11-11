from tkinter import *
import requests
from bs4 import BeautifulSoup
from datetime import datetime

def getCourse(id):
    return xml.find("valute", {'id': id}).value.text

url = "http://www.cbr.ru/scripts/XML_daily.asp?"
today = datetime.today()
today = today.strftime("%d/%m/%y")
#url = url + today
payload = {"date_req" : today}
response = requests.get(url, params=payload)
xml = BeautifulSoup(response.content, "lxml")


root = Tk()
root.title("мое приложение")
root.geometry("500x500")

usd_course = Label(root, text="КУрс доллара: " + getCourse("R01235"), font="16")
usd_course.place(x=0, y=0)

eur_course = Label(root, text="КУрс евро: " + getCourse("R01239"), font="16")
eur_course.place(x=0, y=50)

root.mainloop() 