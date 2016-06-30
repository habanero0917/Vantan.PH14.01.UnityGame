using UnityEngine;
using System.Collections;

public class SarchAreaJob : MonoBehaviour {

	JobCtrl JobCtrl;
	void Start()
	{
		// JobCtrlをキャッシュする
		JobCtrl = transform.root.GetComponent<JobCtrl>();
	}

	void OnTriggerStay( Collider other )
	{
		// Playerタグをターゲットにする
		if( other.tag == "Player" )
			JobCtrl.SetAttackTarget( other.transform );
	}
}
