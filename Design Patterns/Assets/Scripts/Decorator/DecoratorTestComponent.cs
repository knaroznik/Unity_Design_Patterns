using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoratorTestComponent : MonoBehaviour {

	void Start () {

		ObjectPool.GetInstance ().AddPrototype (SceneData.GetInstance().pizzaPrefab, ObjType.PIZZA);
		ObjectPool.GetInstance ().AddPrototype (SceneData.GetInstance().hamPrefab, ObjType.HAM);
		ObjectPool.GetInstance ().AddPrototype (SceneData.GetInstance().chickenPrefab, ObjType.CHICKEN);
		ObjectPool.GetInstance ().AddPrototype (SceneData.GetInstance().mushroomPrefab, ObjType.MUSHROOM);
		ObjectPool.GetInstance ().InitPool ();


		IPizza smallPizza = new SmallPizza ();


		for (int i = 0; i < 3; i++) {
			int x = Random.Range (0, 3);
			if (x == 0) {
				smallPizza = new HamDecorator (smallPizza);
			} else if (x == 1) {
				smallPizza = new ChickenDecorator (smallPizza);
			} else {
				smallPizza = new MushroomDecorator (smallPizza);
			}
		}

		smallPizza.CreatePizza (Vector3.zero);
	}
}
