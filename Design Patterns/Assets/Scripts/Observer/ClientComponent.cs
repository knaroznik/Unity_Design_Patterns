using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientComponent : MonoBehaviour {

	private Client client;
	//Temporary, change after generating clients
	public int number;

	public Transform pizzaTransform;

	void Start () {
		client =  new Client(this.gameObject);
		client.ChooseRandomPizza (pizzaTransform.position, this.gameObject);
		((MainSceneData)MainSceneData.GetInstance ()).pizzaComponents [number].AddObservator (client);
	}
}
