# MEDIATOR DESIGN PATTERN

-----

**Name:** Jefersson Coronel Lavadenz

**Subject:** Software Development 5

**Trainer:** Carlos Pammo

-----

The Mediator design pattern is a behavioral design pattern that lets you reduce chaotic dependencies between objects. The pattern restricts direct communications between the objects and forces them to collaborate only via a mediator object.

- **Purpose:** The Mediator pattern is used to define an object that encapsulates how a set of objects interact. It promotes loose coupling by preventing objects from referring to each other explicitly and allows their interaction to be independent.
- **Use:** It's used when there's a complex set of interactions between objects and you want to decouple these objects by avoiding direct references between them.
- **Structure:** The typical structure of the Mediator pattern includes a mediator object that coordinates interactions between colleague objects. Colleagues communicate with each other through the mediator, rather than directly.

**My project using mediator design pattern:**

[![Mediator-Design-Pattern-Diagram.jpg](https://i.postimg.cc/BnWnRwmD/Mediator-Design-Pattern-Diagram.jpg)](https://postimg.cc/nCkxDTbc)

1. **IChatRoomMediator Interface:**
    - This interface declares a method SendMessage for sending messages to users. 
    - It serves as the contract for mediator implementations.
2. **ChatRoomMediatorImpl Class (Concrete Mediator):**
    - This class implements the IChatRoomMediator interface.
    - It maintains a list of users and allows the addition of users.
    - The SendMessage method sends a message to all users except the sender.
3. **User Abstract Class (Colleague):**
    - This abstract class represents a colleague (user) participating in the chat room.
    - It contains properties for mediator and user name, and abstract methods Send and Receive for sending and receiving messages.
4. **UserImpl Class (Concrete Colleague):**
    - This class extends the User abstract class and implements its abstract methods.
    - It provides concrete implementations of the Send and Receive methods.
5. **MediatorExample Class:**
    - This class contains the Main method and serves as the entry point of the program.
    - It demonstrates the usage of the Mediator pattern by creating a mediator instance, several user instances, adding users to the mediator, and simulating message exchange between users.