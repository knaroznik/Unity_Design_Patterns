using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TableComponent : MonoBehaviour, IObservable {

	public GameObject pizzaValue{ get; set;}

	public void AddObservator (IObservator o){
		observatorList.Add (o);
	}

	public void DeleteObservator (IObservator o){
		if (observatorList.Contains (o))
			observatorList.Remove (o);
	}

	public void SyncData(){
		foreach(IObservator o in observatorList.ToList()){
			o.SyncPizza (pizzaValue);
		}
	}

	private List<IObservator> observatorList = new List<IObservator>();

}
