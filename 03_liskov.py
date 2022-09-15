from abc import ABC, abstractmethod

class Notification(ABC):
    @abstractmethod
    def notify(self, message, email = str):
        pass

class Email(Notification):
    def notify(self, message, email):
        print(f'send {message} to {email}')

class SMS(Notification):
    def notify(self, message, email):
        print(f'send {message} to {email}')

class Contact:
    def __init__(self, name, email, phone):
        self.name = name
        self.email = email
        self.phone = phone

class NotificationManager:
    def __init__(self, notification, contact):
        self.contact = contact
        self.notification = notification

    def send(self, message):
        if isinstance(self.notification, Email):
            self.notification.notify(message, contact.email)
        elif isinstance(self.notification, SMS):
            self.notification.notify(message, contact.phone)
        else:
            raise Exception ('La notificación que nos enviaste no esta disponible por este momento.')

if __name__ == '__main__':
    contact = Contact ("Aaron Rosas", "aaron.rosas@criptext.com", "5519004551")
    n_manager = NotificationManager(SMS(), contact)
    n_manager.send("Hola => ")

"""     _notificacion = Email ()
    _notificacion.notify("hola", "aaron.rosas@criptext.com") """