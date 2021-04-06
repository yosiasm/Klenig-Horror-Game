using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swiperjanganmencuri : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	private Vector2 fingerStart;
	private Vector2 fingerEnd;
	public tompon weapon;
	public tomcard card;
	public avatarmisc amis;

	public int leftRight = 0;
	public int upDown = 0;

	bool left,right,up,down;
	void falssing(){
		left = false;
		right = false;
		down = false;
		up = false;
	}
	public void jangankeluar() {
		weapon.mulai = false;
		card.mulai = false;
	}

	void Update () {
		if (amis.naik) {
			foreach (Touch touch in Input.touches) {
				if (touch.phase == TouchPhase.Began) {
					fingerStart = touch.position;
					fingerEnd = touch.position;
				}
				if (touch.phase == TouchPhase.Moved) {
					fingerEnd = touch.position;

				}
				if (touch.phase == TouchPhase.Ended) {
					if ((fingerStart.x - fingerEnd.x) > 80) {
						falssing ();
						left = true;
						card.mulai = false;

					}
					if ((fingerStart.x - fingerEnd.x) < -80) {
						falssing ();
						right = true;
						if (!weapon.mulai) {
							card.mulai = true;
						}
					}
					if ((fingerStart.y - fingerEnd.y) < -80) {
						falssing ();
						down = true;
						if (!card.mulai) {
							weapon.mulai = true;
						}


					}
					if ((fingerStart.y - fingerEnd.y) > 80) {
						falssing ();
						up = true;
						weapon.mulai = false;
					}

				}
			}
		}



			if (card.mulai && !weapon.mulai) {

				GameObject.Find ("circa").transform.localPosition = 
					Vector3.Lerp (GameObject.Find ("circa").transform.localPosition, new Vector2 (1000, 0), 2 * Time.deltaTime);	


			} else if (weapon.mulai && !card.mulai) {

				GameObject.Find ("circa").transform.localPosition = 
					Vector3.Lerp (GameObject.Find ("circa").transform.localPosition, new Vector2 (0,1500), 2 * Time.deltaTime);


			} else {

				GameObject.Find ("circa").transform.localPosition = 
					Vector3.Lerp (GameObject.Find ("circa").transform.localPosition, new Vector2 (0, 0), 2 * Time.deltaTime);



			}
		

	}
}
