using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shake_sprite : MonoBehaviour
{
	AudioSource audio;
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
        gameObject.transform.position = Vector3.right * 30f;
    }
	void play_audio(){
    	if(!audio.isPlaying){
    		audio.clip = Resources.Load<AudioClip>("sfx/birth");
    		audio.Play();	
    	}
    	
    }
    void Update()
    {
    	if(gameObject.transform.position.x < 5f){
	        Vector3 position = new Vector3(Random.Range(-0.3f, 0.3f), Random.Range(-0.3f, 0.3f),0);
	        gameObject.transform.position = position;
	        play_audio();
	    }
    }
}
