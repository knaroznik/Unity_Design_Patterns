﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenDecorator : PizzaDecorator {

	public ChickenDecorator(IPizza pizza) : base(pizza){
	}

	public override void CreatePizza (Vector3 pos)
	{
		base.CreatePizza (pos);
		GameObject obj = PlaceObject (ObjType.CHICKEN, chickenPosition, PizzaCake ().transform);
		objUsing.Add (obj, ObjType.CHICKEN);
	}
}