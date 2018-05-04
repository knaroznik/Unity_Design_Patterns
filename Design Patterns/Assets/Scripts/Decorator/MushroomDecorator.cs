using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomDecorator : PizzaDecorator {

	public MushroomDecorator(IPizza pizza) : base(pizza){
	}

	public override void CreatePizza ()
	{
		
		base.CreatePizza ();
		Debug.Log("MUSHROOM");
		GameObject obj = PlaceObject (ObjType.MUSHROOM, mushroomPosition, PizzaCake ().transform);
		objUsing.Add (obj, ObjType.MUSHROOM);
	}
}
