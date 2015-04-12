# Windsor Generic Factory Example

This is a sample solution to support an (upcoming blog post)[http://iamkoch.com] regarding anti-patterns and how one can attempt to remove Service Locator in certain situations.

The sitation addressed in this particular project allows implementators to pull down an implementation of a generic handler interface, in this case `ICommandHandler<T>`.

This interface offers a single method - `Handle<T>(T command)` and is an answer to a previous project I worked on in which we had the following dependency chain:

```
ICommandExecutor<T>.Execute(T command)
--> ServiceLocator.Current.GetInstance<ICommandHandler<T>>().Handle(command)
```

The solution could be modified to return multiple implementations in order to have a more distributed, multi-handler style approach.
