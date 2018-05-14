using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneData : MonoBehaviour {

	public List<TableComponent> pizzaComponents;
	public Transform userTableTransform;

	protected static MainSceneData instance;
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

	public static MainSceneData GetInstance (){
		return instance;
	}
}
