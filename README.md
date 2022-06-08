# AR.Constants

This is a utility library containing a collection of constant numbers making them easy to use
without the need to remember their values.

The Math constants are mostly inspired from the [List of mathematical constants Wikipedia Page](https://en.wikipedia.org/wiki/List_of_mathematical_constants)

Holding up to 10 decimals.

Include the using statement in your code:
```c#
using static AR.Constants.Math;
```

## Example usage: 
```c#
using System;
using static AR.Constants.Math;

public class Program
{
	public void Main(string[] args)
	{
		Console.WriteLine(PI * GOLDEN_RATIO)
	}
}
```