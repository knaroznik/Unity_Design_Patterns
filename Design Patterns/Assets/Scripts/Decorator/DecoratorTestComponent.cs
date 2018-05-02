using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoratorTestComponent : MonoBehaviour {

	// Use this for initialization
	void Start () {
		IPizza smallPizza = new SmallPizza ();
		smallPizza = new CheeseDecorator (smallPizza);
		DebugList (smallPizza.GetProducts ());
		smallPizza = new CheeseDecorator (smallPizza);
		DebugList (smallPizza.GetProducts ());
		smallPizza = new CheeseDecorator (smallPizza);
		DebugList (smallPizza.GetProducts ());

	}

	void DebugList(List<string> list){
		string output = "";
		for (int i = 0; i < list.Count; i++) {
			output += list [i] + " ";
		}
		Debug.Log (output);
	}
}
