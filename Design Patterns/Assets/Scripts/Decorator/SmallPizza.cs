using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SmallPizza : Pizza {

	public override GameObject CreatePizza (Vector3 pos)
	{
		ClearPizza ();
		GameObject obj = PlaceObject (ObjType.PIZZA, pos, null);
		pizzaCake = obj;
		class_object = obj;
		class_type = ObjType.PIZZA;
		return obj;
	}

	public override void ClearPizza ()
	{
		if(class_object != null)
			ObjectPool.GetInstance ().ReleaseReusable (class_object, class_type);
	}

	public override GameObject PizzaCake ()
	{
		return pizzaCake;
	}
}
