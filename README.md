# Notes for the session taken on 23rd August, 2017

## Dynamic Arrays

*See DataStructureDemo.cs*

Arrays are terrible. They are error prone and difficult to work with. One way we can solve this by sort of wrapping it in a class.

This is sort of an Abstract Data Type.

The array is represented by an private member. We add elements without thinking about it.

The array can be an array of type Object so that it can hold elements of any type.

## Linked List

A Linked list is a data structure that connects a list of objects of the same class using a reference to the next link in the chain.

It would look something like this:
<pre>
+--------------+        +---------------+       +---------------+
|class List {  |        |class List {   |       |class List {   |
|   int i;     |        |   int i;      |       |   int i;      |
|   List next;+-------->|   List next;--------->|  List next;   |
|}             |        |}              |       |}              |
+--------------+        +---------------+       +---------------+
  object1                   object2                 object3
</pre>

Example: LinkedList and LinkedListManager

Linked Lists are an alternative to dynamic arrays and have different properties.

Lots of helper functions are needed to implement these.

What's important to take away from these is that these data structures are implemented in different ways and have their own beneifts and pitfalls. This means that in some situations, one may be better suited than the other and vice-versa.

## Parameterized Types (Generics)

For classes such as these, the "type" of object stored can be substituted.

For example, see; DynamicArrayWithParameter<T>

Also known as Generics.

## What is a "Type"?

A Type is the collection of methods that you can call on an objects. Methods are also known as operations. Think of it as giving commands to the object or making the object do stuff.

See my article [here](https://dhavalonline.wordpress.com/2017/06/17/what-types-are-in-oop-really/) for more.


## State

The set of the current values of an object is called its state.

From SO:
*...An object is an entity that has state, behavior, and identity. The structure and behavior of similar objects are defined in their common class. The terms instance and object are interchangeable.*

We will consider the concepts of state, behavior, and identity in more detail in the sections that follow. ...

And there is a whole subsection that describes the concept of state:

*... From this example, we may form the following low-level definition.*

*The state of an object encompasses all of the (usually static) properties of the object plus the current (usually dynamic) values of each of these properties ...*

