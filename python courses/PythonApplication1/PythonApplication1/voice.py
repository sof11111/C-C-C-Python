#my_file = open("file.txt", "a")  #создали файл 
#my_file.write("TextTextText")    #запись в неё текста
#my_file.close()

#print(my_string) 

my_file = open("file.txt", "r") #сохранили то что находится в файле 
my_string = my_file.read()
my_file.close()


import os 
from pygame import mixer
from gtts import gTTS 

mp3_name = "audio.mp3"  #создали аудио файл 

mixer.init()

tts = gTTS(my_string, lang='ru') #запуск библиотеки гугл переводчика то есть озвучки 
tts.save(mp3_name)  #сохранение 

#mixer.music.load(mp3_name) 