SINGLETON DESGIN PATTERN

A class only has one instance and provide a global point of access to it throughout the life of an application.

STRUCTURE

Should have a private or protected constructor. 

No public and parameterized constructors.


Should have a static property (with a private backing field) to return an instance of a class. 

A static method can also be used to return an instance.

At least have one non-static public method for a singleton operation.