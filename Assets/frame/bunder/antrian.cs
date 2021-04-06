using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class antrian : MonoBehaviour {

	// Use this for initialization
	void Start () {

		StartCoroutine (summonv ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public List<Sprite> minion;
	public Sprite glow;
	IEnumerator summonv(){
		float frekuensi = 1f;
		float spit = 0.2f;
		while(true){
			yield return new WaitForSeconds (frekuensi);
			frekuensi = frekuensi > 0.4f ? frekuensi - 0.01f : 0.4f;
			spit = spit < 0.7f ? spit + 0.01f : 0.7f;
			GameObject uhuk = new GameObject ();
			Image ga = uhuk.AddComponent<Image> ();
			int ind = Random.Range (0, 4);
			ga.sprite = minion [ind];
			uhuk.GetComponent<RectTransform>().SetParent(this.transform);
			minion asdf = uhuk.AddComponent<minion> ();
			asdf.vertikal = true;
			asdf.spit = spit;
			asdf.id = ind + 1;

			uhuk.SetActive (true);
			Destroy (uhuk, 4);

		}
	}
}
