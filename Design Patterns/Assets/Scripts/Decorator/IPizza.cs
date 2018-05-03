using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IPizza : IObjectPooled {
	
	public GameObject PlaceObject(ObjType obj, Vector3 position, Transform parent)
	{
		GameObject x = ObjectPool.GetInstance ().acquireReusable (obj);
		x.transform.position = position;
		x.transform.SetParent (parent);
		return x;
	}


	protected Vector3 hamPosition = new Vector3 (-1.3f, 1f, -1f);
	protected Vector3 mushroomPosition;
	protected Vector3 chickenPosition;

	protected GameObject pizzaCake;

	protected Dictionary<GameObject, ObjType> objUsing = new Dictionary<GameObject, ObjType> ();

	public abstract void CreatePizza ();
	public abstract void ClearPizza();
	public abstract GameObject PizzaCake ();
}
