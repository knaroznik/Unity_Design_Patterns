using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : IObservator{

	private ICommand command;
	private List<ObjType> wantedTypes;
	private int x;

	public Client(ICommand _command, int _x){
		command = _command;
		x = _x;
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
		wantedTypes = types;
		return types;
	}

	private void CreatePizza(List<ObjType> types, Vector3 pizzaPosition, Transform parent){
		Pizza pizza = new SmallPizza ();
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
		List<string> names = new List<string> ();

		for (int i = 0; i < pizza.transform.childCount; i++) {
			names.Add (pizza.transform.GetChild (i).name);
		}

		foreach (ObjType type in wantedTypes) {
			if (type == ObjType.CHICKEN && !names.Contains ("CHICKEN")) {
				return;
			}

			if (type == ObjType.HAM && !names.Contains ("HAM")) {
				return;
			}

			if (type == ObjType.MUSHROOM && !names.Contains ("MUSHROOM")) {
				return;
			}
		}
		MainSceneData.GetInstance ().pizzaComponents [x].DeleteObservator (this);
		GameObject.Destroy (pizza);

		//SETTING NULL ON UserInputComponent

		GameObject.FindObjectOfType<UserInputComponent> ().SetPizza (x, null);

		command.GoOff ();
	}
}
