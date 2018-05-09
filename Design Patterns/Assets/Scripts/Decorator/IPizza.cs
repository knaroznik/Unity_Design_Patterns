using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IPizza : IObjectPooled {
	
	public GameObject PlaceObject(ObjType obj, Vector3 position, Transform parent)
	{
		GameObject x = ObjectPool.GetInstance ().acquireReusable (obj);
		x.transform.SetParent (parent);
		x.transform.localPosition = position;
		return x;
	}

	public Vector3 hamPosition = new Vector3 (-1.3f, 1f, -1f);
	protected Vector3 mushroomPosition = new Vector3 (1.3f, 0.5f, -1f);
	protected Vector3 chickenPosition = new Vector3 (0f, -1f, -1f);

	protected GameObject pizzaCake;

	public Dictionary<GameObject, ObjType> objUsing = new Dictionary<GameObject, ObjType> ();

	public abstract GameObject CreatePizza (Vector3 pos);
	public abstract void ClearPizza();
	public abstract GameObject PizzaCake ();
}
