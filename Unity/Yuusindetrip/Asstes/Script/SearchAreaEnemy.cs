using UnityEngine;
using System.Collections;

public class SearchAreaEnemy: MonoBehaviour {
	EnemyCtrl enemyCtrl;
	void Start()
	{
		// EnemyCtrlをキャッシュする
		enemyCtrl = transform.root.GetComponent<EnemyCtrl>();
	}

	void OnTriggerStay( Collider other )
	{
		// Playerタグをターゲットにする
		if( other.tag == "Player" )
			enemyCtrl.SetAttackTarget( other.transform );
	}
}
