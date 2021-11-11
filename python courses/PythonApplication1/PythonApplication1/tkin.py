from tkinter import *

root = Tk()
root.title("мое приложение")
root.geometry("500x500")

def ChangeLabe():
    count = int(lab['text'])
    count = count + 1
    lab['text'] = count 


#lab = Label(root, text="Какой-то важный текст", bg="red", fg="gold", font="16")
#lab['text'] = "Другой текст"
lab = Label(root, text = "0", bg="red", fg="gold", font = "16")
lab.place(x=0, y=0)

btn = Button(text="Кнопка", background="#000555", foreground="red", font="16", command=ChangeLabe)
btn.place(x=100, y=100)

root.mainloop()