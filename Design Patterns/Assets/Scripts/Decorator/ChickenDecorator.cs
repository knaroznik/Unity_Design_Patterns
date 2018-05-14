using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenDecorator : PizzaDecorator {

	public ChickenDecorator(Pizza pizza) : base(pizza){
	}

	public override GameObject CreatePizza (Vector3 pos)
	{
		//Create class object
		GameObject pizza = base.CreatePizza (pos);
		//Instantiate class object
		GameObject obj = PlaceObject (ObjType.CHICKEN, chickenPosition, PizzaCake ().transform);
		//Save informations : 
		obj.name = "CHICKEN";
		class_object = obj;
		class_type = ObjType.CHICKEN;

		return pizza;
	}
}
