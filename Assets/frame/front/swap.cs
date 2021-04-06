using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class swap : MonoBehaviour, IPointerClickHandler {

	public Sprite sprite1;
	public Sprite sprite2;
	private Image spriteRenderer;

	public float speed;
	private float bawah;
	private float selisih;
	private bool naik = false;
	void Start()
	{
		spriteRenderer = GetComponent<Image> ();
		if (spriteRenderer.sprite==null) {
			spriteRenderer.sprite = sprite1;
		}
		bawah = transform.position.y;
		selisih = Screen.height - bawah;
		speed = 3.5f;
	}
	void Update()
	{
		bawah = Screen.height - selisih;

		if (naik) {
			transform.position = Vector3.MoveTowards (transform.position, turun (Screen.height), speed);	
		} else {
			transform.position = Vector3.MoveTowards (transform.position, turun (bawah), speed);	
		}

		if (transform.position.y == Screen.height) {
			naik = false;
			ubahSprite ();
		}

	}
	void ubahSprite(){
		Debug.Log ("aldkf");
		if (spriteRenderer.sprite == sprite1) {
			spriteRenderer.sprite = sprite2;
		} else {
			spriteRenderer.sprite = sprite1;
		}
	}
	Vector3 turun (float y)
	{
		return new Vector3 (transform.position.x, y, transform.position.z);
	}
	public void OnPointerClick(PointerEventData eventData)
	{
		naik = true;

	}
}
