using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SmallPizza : IPizza {

	public override void CreatePizza ()
	{
		//RESET POZYCJI
		Debug.Log("PIZZA");
		ClearPizza ();
		GameObject obj = PlaceObject (ObjType.PIZZA, Vector3.zero, null);
		pizzaCake = obj;
		objUsing.Add (obj, ObjType.PIZZA);
	}

	public override void ClearPizza ()
	{
		for (int i = 0; i < objUsing.Count; i++) {
			ObjectPool.GetInstance ().ReleaseReusable (objUsing.Keys.ToArray () [i], objUsing.Values.ToArray () [i]);
		}
		objUsing.Clear ();
	}

	public override GameObject PizzaCake ()
	{
		return pizzaCake;
	}





}
