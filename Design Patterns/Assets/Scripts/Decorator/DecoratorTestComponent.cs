using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoratorTestComponent : MonoBehaviour {

	void Start () {

		ObjectPool.GetInstance ().AddPrototype (SceneData.GetInstance().pizzaPrefab, ObjType.PIZZA);
		ObjectPool.GetInstance ().AddPrototype (SceneData.GetInstance().hamPrefab, ObjType.HAM);
		ObjectPool.GetInstance ().InitPool ();


		IPizza smallPizza = new SmallPizza ();
		smallPizza.CreatePizza ();
		smallPizza = new HamDecorator (smallPizza);
		smallPizza.CreatePizza ();
		smallPizza = new HamDecorator (smallPizza);
		smallPizza.CreatePizza ();
	}
}
