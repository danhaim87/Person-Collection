# PersonCollection

1
Development Exercise – Homework Version
Guidelines
You may implement your solution in Java/C#.
Your solution should be well-designed according to OO principles.

Assumptions
The following interface is given (in Java):
Public interface Person
{
Public int getId();
Public String getFirstName();
Public String getLastName();
Public Date getDateOfBirth();
Public int getHeight();
// etc… there may be more such get property methods
}
Requirements
1. You are asked to implement a new class called PersonCollection.
2. Your implementation should support the following operations:
a. Add - adds the person object which is given as input. This operation may be performed in WC time complexity of O(n)
b. Remove - removes the person object with the maximum value and returns it. This operation must be performed in WC time complexity of O(1)
c. Publish - publishes a notification to subscriber objects upon any Add/Remove.
2
3. What does it mean that a person has the maximum value?
a. There may be many possible "algorithms" to determine that e.g. by first name/ last name/ height/ or any new properties of this interface that will be added in the future; you do not know in advance what algorithms may apply and which one should be used. Therefore, design your implementation to be as flexible as possible by supporting all potential algorithms. For example: if the developer of Person interface somehow changes its properties, then this should still not affect your implementation of PersonCollection in any way!
b. For a single instance of PersonCollection, there will be only a single matching algorithm i.e. there is no need to change the algorithm in between operations.
4. Your implementation should be thread-safe.
Good luck! 
