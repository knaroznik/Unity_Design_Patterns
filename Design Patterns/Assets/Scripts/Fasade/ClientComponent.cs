using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientComponent : MonoBehaviour {

	private Client client;
	public Transform pizzaTransform;

	public void Init (int x, ICommand _command) {
		client =  new Client(_command, x);
		client.ChooseRandomPizza (pizzaTransform.position, this.gameObject);
		((MainSceneData)MainSceneData.GetInstance ()).pizzaComponents [x].AddObservator (client);
	}
}
