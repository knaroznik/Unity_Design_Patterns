using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UserInputComponent : MonoBehaviour, IObjectPooled {

	private UserInput userInput;

	private GameObject currObj = null;
	private ObjType type = ObjType.PIZZA;
	private Vector3 pos;

	private IPizza[] pizzas = new IPizza[3];
	private List<TableComponent> pizzaTransforms;

	public GameObject PlaceObject (ObjType obj, Vector3 position, Transform parent)
	{
		GameObject x = ObjectPool.GetInstance ().acquireReusable (obj);
		x.transform.position = position;
		x.transform.SetParent (parent);
		return x;
	}

	void Start(){
		pizzaTransforms = ((MainSceneData)MainSceneData.GetInstance ()).pizzaComponents;

		userInput = new UserInput ();
		pos = ((MainSceneData)MainSceneData.GetInstance ()).userTableTransform.position + new Vector3 (0f, 0f, -5f);
	}

	void Update(){
		//LOSUJEMY CO MA BYC NA STOLE, jeśli już nie ma czego wkazać
		if (currObj == null) {
			int x = UnityEngine.Random.Range (0, 4);
			if (currObj != null) {
				ObjectPool.GetInstance ().ReleaseReusable (currObj, type);
			}

			if (x == 0) {
				currObj = PlaceObject (ObjType.PIZZA, pos, null);
				type = ObjType.PIZZA;
			} else if (x == 1) {
				currObj = PlaceObject (ObjType.CHICKEN, pos, null);
				type = ObjType.CHICKEN;
			} else if (x == 2) {
				currObj = PlaceObject (ObjType.HAM, pos, null);
				type = ObjType.HAM;
			} else {
				currObj = PlaceObject (ObjType.MUSHROOM, pos, null);
				type = ObjType.MUSHROOM;
			}
		} else {
			//CZEKAMY AŻ WSKAŻE USER GDZIE TO WSADZIĆ
			foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode))) {
				if (Input.GetKeyDown (kcode)) {
					if (kcode.ToString () == "Alpha1" || kcode.ToString () == "Alpha2" || kcode.ToString () == "Alpha3") {
						int pizzaNumber = keyCodeToInt(kcode.ToString());
						if (XD (pizzaNumber)) {
							pizzaTransforms [pizzaNumber].pizzaValue = pizzas [pizzaNumber].CreatePizza (pizzaTransforms [pizzaNumber].gameObject.transform.position + new Vector3(0f,0f,-5f));
							pizzaTransforms [pizzaNumber].SyncData ();
							ObjectPool.GetInstance ().ReleaseReusable (currObj, type);
							currObj = null;
						}
					} else if (kcode.ToString () == "Alpha4") {
						ObjectPool.GetInstance ().ReleaseReusable (currObj, type);
						currObj = null;
					} else {
						Debug.Log ("KeyCode down: " + kcode.ToString ());
					}
				}
			}

		}
	}

	int keyCodeToInt(string code){
		if (code == "Alpha1") {
			return 0;
		} else if (code == "Alpha2") {
			return 1;
		} else {
			return 2;
		}
	}

	bool XD(int pizzaNumber){
		if (type == ObjType.PIZZA && pizzas [pizzaNumber] == null) {
			pizzas [pizzaNumber] = new SmallPizza ();
			return true;
		} else if (type != ObjType.PIZZA) {
			if (pizzas [pizzaNumber] != null) {
				if (type == ObjType.CHICKEN) {
					pizzas [pizzaNumber] = new ChickenDecorator (pizzas [pizzaNumber]);
				}else if (type == ObjType.HAM) {
					pizzas [pizzaNumber] = new HamDecorator (pizzas [pizzaNumber]);
				}else if (type == ObjType.MUSHROOM) {
					pizzas [pizzaNumber] = new MushroomDecorator (pizzas [pizzaNumber]);
				}
				return true;
			}
		}
		return false;
	}
}
