using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenDecorator : PizzaDecorator {

	public ChickenDecorator(IPizza pizza) : base(pizza){
	}

	public override GameObject CreatePizza (Vector3 pos)
	{
		GameObject pizza = base.CreatePizza (pos);
		GameObject obj = PlaceObject (ObjType.CHICKEN, chickenPosition, PizzaCake ().transform);
		obj.name = "CHICKEN";
		objUsing.Add (obj, ObjType.CHICKEN);
		return pizza;
	}
}
