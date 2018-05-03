using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HamDecorator : PizzaDecorator {

	public HamDecorator(IPizza pizza) : base(pizza){
	}

	public override void CreatePizza ()
	{
		base.CreatePizza ();
		GameObject obj = PlaceObject (ObjType.HAM, hamPosition, PizzaCake ().transform);
		objUsing.Add (obj, ObjType.HAM);
	}
}
