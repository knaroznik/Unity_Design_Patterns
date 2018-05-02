using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallPizza : IPizza {

	public override List<string> GetProducts ()
	{
		return new List<string> (){ "ciasto" };
	}

	public override string GetName ()
	{
		return "Pizza";
	}



}
