using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObservable {

	GameObject pizzaValue{ get; set;}

	void AddObservator (IObservator o);
	void DeleteObservator (IObservator o);
	void SyncData();
}
