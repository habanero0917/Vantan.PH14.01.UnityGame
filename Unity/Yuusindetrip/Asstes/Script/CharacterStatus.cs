﻿using UnityEngine;
using System.Collections;

public class CharacterStatus : MonoBehaviour
{

	// 体力.
	public int HP = 100;
	public int MaxHP = 100;

	// 攻撃力.
	public int Power = 10;

	// 最後に攻撃した対象.
	public GameObject lastAttackTarget = null;

	// プレイヤー名.
	public string characterName = "Player";

	//状態.
	public bool attacking = false;
	public bool died = false;

	// 攻撃力強化
	public bool powerBoost = false;
	// 攻撃強化時間
	float powerBoostTime = 0.0f;

	// アイテム取得
	public void GetItem(DropItem.ItemKind itemKind)
	{
		switch (itemKind)
		{
		case DropItem.ItemKind.Attack:
			powerBoostTime = 10.0f;
			break;
		case DropItem.ItemKind.Heal:
			// MaxHPの半分回復
			HP = Mathf.Min (HP + MaxHP / 2, MaxHP);
			break;
		}
	}

	void Update()
	{
		powerBoost = false;
		if (powerBoostTime > 0.0f)
		{
			powerBoost = true;
			powerBoostTime = Mathf.Max(powerBoostTime - Time.deltaTime, 0.0f);
		}
		if (Input.GetKey (KeyCode.Space)) {
			gameObject.layer = LayerMask.NameToLayer("player");
		}
	}

}