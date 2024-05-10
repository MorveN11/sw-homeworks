## Chain Responsability

Is a behavioral design pattern used to construct a chain of receiving objects that handle requests sequentially. In this pattern, each object in the chain has the ability to process the request or pass it to the next object in the chain.

You can easily add or remove handlers from the chain without affecting the client. Each request is sent through the chain until a handler processes it or until it reaches the end of the chain without being handled.

## How to implement

1.- Defines a common interface that all handlers in the chain will implement. This interface usually contains a method to handle the request and a reference to the next handler in the chain.

2.= Implement this interface in concrete classes that represent the different handlers in the chain. Each handler class will implement the logic to handle the request or pass it to the next handler if it cannot handle it.

3.- On the client, create an instance of the handler chain and configure the links between them.

## code

Each request has a level associated with it. Depending on the level, the request will be handled by an employee, a manager or a director. If a level cannot handle the request, it is passed on to the next level in the chain.