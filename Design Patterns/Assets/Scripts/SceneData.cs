using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneData : MonoBehaviour {

	protected static SceneData instance;
	public GameObject pizzaPrefab;
	public GameObject hamPrefab;
	public GameObject mushroomPrefab;
	public GameObject chickenPrefab;

	void Awake(){
		instance = this;
		ObjectPool.GetInstance ().AddPrototype (pizzaPrefab, ObjType.PIZZA);
		ObjectPool.GetInstance ().AddPrototype (hamPrefab, ObjType.HAM);
		ObjectPool.GetInstance ().AddPrototype (chickenPrefab, ObjType.CHICKEN);
		ObjectPool.GetInstance ().AddPrototype (mushroomPrefab, ObjType.MUSHROOM);
		ObjectPool.GetInstance ().InitPool ();
	}

	public static SceneData GetInstance (){
		return instance;
	}
}
