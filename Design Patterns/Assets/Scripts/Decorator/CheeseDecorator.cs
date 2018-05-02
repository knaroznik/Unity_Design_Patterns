using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseDecorator : PizzaDecorator {

	public CheeseDecorator(IPizza pizza) : base(pizza){
	}

	public override List<string> GetProducts ()
	{
		List<string> x =  base.GetProducts ();
		x.Add ("cheese");
		return x;
	}

	public override string GetName ()
	{
		return base.GetName ()  + "with cheese";
	}
}
