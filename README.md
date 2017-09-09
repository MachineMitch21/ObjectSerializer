# ObjectSerializer
Simple object serialization library utility

# Classes

## IFormatter implementations 
  1. XmlFormatter (Wraps the XmlSerializer using the IFormatter interface so that all objects can use an IFormatter derived class)

## Base Classes
  1. IObjectSaver
  2. ObjectSaver (Abstract class implementing generic functionality of the IObjectSaver interface)

## Implementation classes
  1. BinaryObjectSaver (Serializes an object to a stream using binary serialization)
  2. XmlObjectSaver (Serializes an object to a stream using xml serialization)
  3. SoapObjectSaver
