using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientsManager : MonoBehaviour {

	public Transform[] clientPlaces;
	private bool[] clientsStatus = new bool[3]{false, false, false};
	public GameObject clientPrefab;

	void Start(){
		LetClientsIn ();
	}

	public void LetClientsIn(){
		int x = Random.Range (1, 4);

		for (int i = 0; i < x; i++) {
			LetClientIn (i);
		}
	}

	private void LetClientIn(int i){
		if (clientsStatus [i] == false) {
			ICommand client = new ClientCommand (this, i);
			client.GoIn ();
			clientsStatus[i] = true;
		}
	}

	public void FreeSeat(int i){
		clientsStatus [i] = false;
	}
}
