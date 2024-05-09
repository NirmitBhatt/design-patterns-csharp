# Observer Design Pattern
***

#### Observer is a Behavioral Design Pattern that lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they are observing.

Observer Design Pattern defines a one-to-many dependency between objects where: 

1. One object is the **"Observable"** (Subject/Publisher) and
2. Other objects are **"Observers"** (Subscribers)

The **Observable** notify all the Observers when a change occurs in its state.
The **Observers** listen to the changes of the Observable.

The Observer Design Pattern can be implemented with the following structure:
    * An IObservable interface (that can be observed) that can be observed by many observers/subscribers.
    * An IObserver interface (that can observe) that observes one observable/subject/publisher.
    * A ConcreteObservable that implements IObservable.
    * A ConcreteObserver that implement IObserver.

![Observer Structure](StructureObserver.png) 