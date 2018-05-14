using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomDecorator : PizzaDecorator {

	public MushroomDecorator(IPizza pizza) : base(pizza){
	}

	public override GameObject CreatePizza (Vector3 pos)
	{
		GameObject pizza = base.CreatePizza (pos);
		GameObject obj = PlaceObject (ObjType.MUSHROOM, mushroomPosition, PizzaCake ().transform);
		obj.name = "MUSHROOM";
		objUsing.Add (obj, ObjType.MUSHROOM);
		return pizza;
	}
}
