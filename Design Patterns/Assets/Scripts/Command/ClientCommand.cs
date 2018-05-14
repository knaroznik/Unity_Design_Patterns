using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientCommand : ICommand {

	ClientsManager manager;
	public int tableNumber;
	GameObject client;

	public ClientCommand(ClientsManager _manager, int _tableNumber){
		manager = _manager;
		tableNumber = _tableNumber;
	}

	public void GoIn(){
		client = GameObject.Instantiate (manager.clientPrefab, manager.clientPlaces [tableNumber].position, Quaternion.identity);
		client.GetComponent<ClientComponent> ().Init (tableNumber, this);
	}

	public void GoOff(){
		GameObject.Destroy (client);
		manager.FreeSeat (tableNumber);
		manager.LetClientsIn ();
	}

}
