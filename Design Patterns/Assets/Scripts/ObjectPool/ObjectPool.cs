using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObjectPool{
	private Dictionary<ObjType, List<GameObject>> _available = new Dictionary<ObjType, List<GameObject>>();
	private Dictionary<ObjType, GameObject> _prototypes = new Dictionary<ObjType, GameObject> ();

	private static ObjectPool instance = null;
	public static ObjectPool GetInstance()
	{
		if (instance == null)
		{
			instance = new ObjectPool();
		}
		return instance;
	}
	public GameObject acquireReusable(ObjType type)
	{
		List<GameObject> reusables = _available [type];
		if (reusables.Count > 0)
		{
			GameObject item = reusables[0];
			reusables.RemoveAt(0);
			item.SetActive (true);
			return item;
		}
		else
		{
			GameObject obj = GameObject.Instantiate (_prototypes [type]);
			return obj;
		}
	}

	public void ReleaseReusable(GameObject item, ObjType type)
	{
		_available [type].Add (item);
		item.SetActive (false);
		item.transform.SetParent (null);
	}

	public void AddPrototype(GameObject obj, ObjType type){
		_prototypes.Add (type, obj);
	}

	public void InitPool(){
		for (int i = 0; i < _prototypes.Count; i++) {
			_available.Add (_prototypes.Keys.ToArray()[i], new List<GameObject> ());
		}

	}
}

public enum ObjType{PIZZA, HAM, CHICKEN, MUSHROOM}
