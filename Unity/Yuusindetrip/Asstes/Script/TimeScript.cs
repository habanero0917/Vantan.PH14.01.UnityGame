using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour {
	private float time = 120;


	void Start () {
		//初期値120を表示
		//float型からint型へCastし、String型に変換して表示
		GetComponent<Text>().text = ((int)time).ToString();
	}

	void Update() {
		Timeman ();
	}

	public void Timeman (){
		
		//1秒に1ずつ減らしていく
		time -= Time.deltaTime;
		//マイナスは表示しない
		if (time < 0) {
			SceneManager.LoadScene ("Title");
		}
		GetComponent<Text> ().text = ((int)time).ToString ();
	}

	public void TimeUp (){
		Debug.Log ("timeUp");
		time += Time.deltaTime;
	}

}