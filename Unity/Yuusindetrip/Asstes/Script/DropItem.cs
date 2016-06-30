using UnityEngine;
using System.Collections;

public class DropItem : MonoBehaviour {
	public enum ItemKind
	{
		Attack,
		Heal,
	};
	public ItemKind kind;
	
	void OnTriggerEnter(Collider other)
	{	
		// Playerか判定
		if( other.tag == "Player" ){
			CharacterStatus aStatus = other.GetComponent<CharacterStatus>();
			aStatus.GetItem(kind);

		
		}
	}

	// Use this for initialization
	void Start () {
		Vector3 velocity = Random.insideUnitSphere * 2.0f + Vector3.up * 8.0f;
		GetComponent<Rigidbody>().velocity = velocity;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
