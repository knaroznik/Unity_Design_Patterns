using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HamDecorator : PizzaDecorator {

	public HamDecorator(Pizza pizza) : base(pizza){
	}

	public override GameObject CreatePizza (Vector3 pos)
	{
		
		GameObject pizza = base.CreatePizza (pos);
		GameObject obj = PlaceObject (ObjType.HAM, hamPosition, PizzaCake ().transform);
		obj.name = "HAM";
		class_object = obj;
		class_type = ObjType.HAM;
		return pizza;
	}
}
