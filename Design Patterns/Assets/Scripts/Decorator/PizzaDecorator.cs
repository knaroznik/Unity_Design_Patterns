using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PizzaDecorator : IPizza {

	protected IPizza _pizza;

	public PizzaDecorator(IPizza pizza){
		_pizza = pizza;
	}

	public override void CreatePizza ()
	{
		ClearPizza ();
		_pizza.CreatePizza ();
	}

	public override void ClearPizza ()
	{
		for (int i = 0; i < objUsing.Count; i++) {
			ObjectPool.GetInstance ().ReleaseReusable (objUsing.Keys.ToArray () [i], objUsing.Values.ToArray () [i]);
		}
		objUsing.Clear ();
	}

	public override GameObject PizzaCake ()
	{
		return _pizza.PizzaCake ();
	}
}
