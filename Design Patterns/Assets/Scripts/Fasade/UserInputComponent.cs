using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UserInputComponent : MonoBehaviour {

	private UserInput userInput;

	void Start(){
		userInput = new UserInput (MainSceneData.GetInstance ().userTableTransform.position + new Vector3 (0f, 0f, -5f),
			MainSceneData.GetInstance ().pizzaComponents
		);
	}

	void Update(){
		userInput.ChooseUserAction ();
	}

	public void SetPizza(int x, Pizza newValue){
		userInput.SetPizza (x, newValue);
	}
}
