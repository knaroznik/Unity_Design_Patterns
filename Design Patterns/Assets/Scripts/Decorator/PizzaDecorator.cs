using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaDecorator : IPizza {

	protected IPizza _pizza;

	public PizzaDecorator(IPizza pizza){
		_pizza = pizza;
	}

	public override List<string> GetProducts ()
	{
		return _pizza.GetProducts ();
	}

	public override string GetName ()
	{
		return _pizza.GetName ();
	}
}
