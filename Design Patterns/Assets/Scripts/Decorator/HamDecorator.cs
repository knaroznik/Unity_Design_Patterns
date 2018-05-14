using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HamDecorator : PizzaDecorator {

	public HamDecorator(IPizza pizza) : base(pizza){
	}

	public override GameObject CreatePizza (Vector3 pos)
	{
		
		GameObject pizza = base.CreatePizza (pos);
		GameObject obj = PlaceObject (ObjType.HAM, hamPosition, PizzaCake ().transform);
		obj.name = "HAM";
		objUsing.Add (obj, ObjType.HAM);
		return pizza;
	}
}
