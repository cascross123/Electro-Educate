using UnityEngine;
using System.Collections;

public class create_object : MonoBehaviour {
	public GameObject Prefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnMouseDown() {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray))
				Instantiate(Prefab, transform.position, transform.rotation);
		
	
	}
}
