using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObjectPooled {

	GameObject PlaceObject(ObjType obj, Vector3 position, Transform parent);
}
