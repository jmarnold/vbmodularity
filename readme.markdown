What is this?
--
This is a simple example that illustrates a common scenario:

> I have an existing application and I would love to start developing new features in FubuMVC.
 
To be more specific, there is an existing WebForms project written in VB.NET and you want to see if it's possible to use FubuMVC to extend things.

Usage
--
Simply open the MainApp.sln file and run the application. The modular-enabling Bottles framework is used here and the FubuMVC portion of the solution is written as a Bottle/Fubu package in C#. The two pieces are linked via the ".links" file found in the root of the MainApp project -- the use of ".links" is recommended only for development-mode.