using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientComponent : MonoBehaviour {

	private Client client = new Client();

	public Transform pizzaTransform;

	void Start () {
		client.ChooseRandomPizza (pizzaTransform.position, this.gameObject);
	}
}
