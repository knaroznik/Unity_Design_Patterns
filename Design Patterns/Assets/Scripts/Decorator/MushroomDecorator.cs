using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomDecorator : PizzaDecorator {

	public MushroomDecorator(Pizza pizza) : base(pizza){
	}

	public override GameObject CreatePizza (Vector3 pos)
	{
		GameObject pizza = base.CreatePizza (pos);
		GameObject obj = PlaceObject (ObjType.MUSHROOM, mushroomPosition, PizzaCake ().transform);
		obj.name = "MUSHROOM";
		class_object = obj;
		class_type = ObjType.MUSHROOM;
		return pizza;
	}
}
