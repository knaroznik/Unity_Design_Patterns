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
	}

	public static SceneData GetInstance (){
		return instance;
	}
}
