using UnityEngine;
using System.Collections;

public class Gold : EObject {
	
	public static Gold Create(	Object  prefab, 
								Vector3 position, 
								Engine  engine,			//this may not be necessary
								string  description, 
								string  name, 
								int 	weigth) {
		
		GameObject gameObj = Instantiate(prefab, position, Quaternion.identity) as GameObject;
		Gold       gold    = gameObj.GetComponent<Gold>();
		
		gold.weigth        = weigth;
		gold.description   = description;
		gold.name          = name;
		
		return gold;
	}
}