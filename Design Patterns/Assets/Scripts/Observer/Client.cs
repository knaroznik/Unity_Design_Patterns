using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : IObservator{

	//Remove in next patches.
	private GameObject objToName;

	public Client(GameObject obj){
		objToName = obj;
	}

	public void ChooseRandomPizza (Vector3 pizzaPosition, GameObject parent){
		CreatePizza (FillTypes (), pizzaPosition, parent.transform);
	}

	private List<ObjType> FillTypes(){
		int x;
		List<ObjType> types = new List<ObjType> ();

		for (int i = 0; i < 4; i++) {
			x = Random.Range (0, 3);
			if (x == 0) {
				if (!types.Contains (ObjType.CHICKEN)) {
					types.Add (ObjType.CHICKEN);
				}
			}

			if (x == 1) {
				if (!types.Contains (ObjType.HAM)) {
					types.Add (ObjType.HAM);
				}
			}

			if (x == 2) {
				if (!types.Contains (ObjType.MUSHROOM)) {
					types.Add (ObjType.MUSHROOM);
				}
			}
		}

		return types;
	}

	private void CreatePizza(List<ObjType> types, Vector3 pizzaPosition, Transform parent){
		IPizza pizza = new SmallPizza ();
		for (int i = 0; i < types.Count; i++) {
			if (types [i] == ObjType.CHICKEN) {
				pizza = new ChickenDecorator (pizza);
			}

			if (types [i] == ObjType.HAM) {
				pizza = new HamDecorator (pizza);
			}

			if (types [i] == ObjType.MUSHROOM) {
				pizza = new MushroomDecorator (pizza);
			}
		}

		GameObject pizzaObj = pizza.CreatePizza (pizzaPosition + new Vector3(0f,0f, -2f));
		pizzaObj.transform.SetParent (parent);
		pizzaObj.transform.localScale = new Vector3 (0.25f, 0.25f, 0.25f);
	}

	public void SyncPizza (GameObject pizza){
		//TUTAJ SPRAWDZIĆ CZY PIZZA OK, CZY MOŻNA WYJŚĆ ITD.
		Debug.Log (objToName.name + " pizza");
	}
}
