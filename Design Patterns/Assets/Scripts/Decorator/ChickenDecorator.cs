using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenDecorator : PizzaDecorator {

	public ChickenDecorator(IPizza pizza) : base(pizza){
	}

	public override void CreatePizza ()
	{
		base.CreatePizza ();
		Debug.Log("CHICKEN");
		GameObject obj = PlaceObject (ObjType.CHICKEN, chickenPosition, PizzaCake ().transform);
		objUsing.Add (obj, ObjType.CHICKEN);
	}
}
