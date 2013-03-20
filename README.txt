This repository demonstrates the ComComponentActivator for Castle Windsor.

There is a sample COM Component along with a couple of unit tests that demonstrate the container behaviour in question.

By default, in .net 4, the first test will throw an exception. The container is unable to create an uninitialised object. 
The custom activator uses the Activator.CreateInstance method to instantiate a new instance of the class.