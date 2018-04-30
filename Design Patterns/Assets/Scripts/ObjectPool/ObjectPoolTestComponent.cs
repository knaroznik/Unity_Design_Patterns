using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolTestComponent : MonoBehaviour {

	public GameObject cube;
	public GameObject capsule;
	public GameObject sphere;

	void Start () {
		ObjectPool.GetInstance ().AddPrototype (cube, ObjType.CUBE);
		ObjectPool.GetInstance ().AddPrototype (capsule, ObjType.CAPSULE);
		ObjectPool.GetInstance ().AddPrototype (sphere, ObjType.SPHERE);

		ObjectPool.GetInstance ().InitPool ();

		//Several objects : 
//		for (int i = 0; i < 3; i++) {
//			GameObject obj = ObjectPool.GetInstance ().acquireReusable (ObjType.CUBE);
//			obj.transform.position = new Vector3 (i, 5f, 0f);
//		}
//
//		for (int i = 0; i < 3; i++) {
//			GameObject obj = ObjectPool.GetInstance ().acquireReusable (ObjType.CAPSULE);
//			obj.transform.position = new Vector3 (i, 0f, 0f);
//		}
//
//		for (int i = 0; i < 3; i++) {
//			GameObject obj = ObjectPool.GetInstance ().acquireReusable (ObjType.SPHERE);
//			obj.transform.position = new Vector3 (i, -5f, 0f);
//		}

		//Check if objectPool works : 

//		List<GameObject> objs = new List<GameObject> ();
//		for (int i = 0; i < 9; i++) {
//			GameObject obj = ObjectPool.GetInstance ().acquireReusable (ObjType.CUBE);
//			obj.transform.position = new Vector3 (i, 0f, 0f);
//			objs.Add (obj);
//		}
//
//		ObjectPool.GetInstance ().ReleaseReusable (objs [2], ObjType.CUBE);
//		ObjectPool.GetInstance ().ReleaseReusable (objs [4], ObjType.CUBE);
//		ObjectPool.GetInstance ().ReleaseReusable (objs [6], ObjType.CUBE);
//		ObjectPool.GetInstance ().ReleaseReusable (objs [8], ObjType.CUBE);
//
//		ObjectPool.GetInstance ().acquireReusable (ObjType.CUBE);
//		ObjectPool.GetInstance ().acquireReusable (ObjType.CUBE);
//		ObjectPool.GetInstance ().acquireReusable (ObjType.CUBE);

	}

}

public enum ObjType{CUBE, CAPSULE, SPHERE}
