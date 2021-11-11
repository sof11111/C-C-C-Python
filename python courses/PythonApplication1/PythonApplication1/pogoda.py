import requests 
from bs4 import BeautifulSoup

url = "https://yandex.ru/pogoda/moscow"
response = requests.get(url)
html = BeautifulSoup(response.content, "lxml")

def temp():
    return html 
