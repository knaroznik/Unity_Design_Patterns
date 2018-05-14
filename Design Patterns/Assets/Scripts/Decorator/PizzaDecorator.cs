using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PizzaDecorator : Pizza {

	protected Pizza _pizza;

	public PizzaDecorator(Pizza pizza){
		_pizza = pizza;
	}

	public override GameObject CreatePizza (Vector3 pos)
	{
		ClearPizza ();
		return _pizza.CreatePizza (pos);
	}

	public override void ClearPizza ()
	{
		if(class_object != null)
			ObjectPool.GetInstance ().ReleaseReusable (class_object, class_type);
	}

	public override GameObject PizzaCake ()
	{
		return _pizza.PizzaCake ();
	}
}
