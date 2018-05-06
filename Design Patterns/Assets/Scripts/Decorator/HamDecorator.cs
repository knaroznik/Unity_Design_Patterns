using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HamDecorator : PizzaDecorator {

	public HamDecorator(IPizza pizza) : base(pizza){
	}

	public override void CreatePizza (Vector3 pos)
	{
		
		base.CreatePizza (pos);
		GameObject obj = PlaceObject (ObjType.HAM, hamPosition, PizzaCake ().transform);

		objUsing.Add (obj, ObjType.HAM);
	}
}
