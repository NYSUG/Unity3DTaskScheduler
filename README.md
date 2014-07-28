Unity3DTaskScheduler
====================

This is a simple utilit for running methods in the future in a Unity3D project.

Example Usage:
Drop the ScheduledTask.cs and Scheduler.cs files somewhere in your Unity3D project.
Call the methods from any other class in the following way:

var scheduler = new Scheduler();
scheduler.Execute(() => MethodToRunInTheFuture(), 1000);

In this example you should have another method called 'MethodToRunInTheFuture()'. 1000 is how many miliseconds to wait until the method is called.
