using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flo_spawn : MonoBehaviour
{
	public string env;
	public string layer;
    Vector3 first_scale;
    Vector3 distance;
    AudioSource audio;

    void Start()
    {
    	distance = new Vector3(Random.Range(-4f, 5f),0,0);
        transform.position = GameObject.Find(env).transform.position + distance;
        first_scale = transform.localScale;
    	audio = gameObject.GetComponent<AudioSource>();

        
    }

    Vector3 movement;
    static float minimum =  0F;
    static float maximum =  0.1F;
    float t = 0.00f;
    void Update()
    {
        t += 0.5f * Time.deltaTime;
    	check_kena();
    	float lerp = Mathf.Lerp(minimum, maximum, t);
    	movement = new Vector3(lerp, lerp, 0);
    	if (lerp == minimum || lerp == maximum)
	    {
	        float temp = maximum;
	        maximum = minimum;
	        minimum = temp;
	        t = 0.0f;
	    }
        transform.localScale = first_scale + movement;
        transform.position = GameObject.Find(env).transform.position + distance;
    }
    void check_kena(){
    	float x = transform.position.x;
    	if(x < 0.5f && x > -0.5f){
    		string player_layer = GameObject.Find("player").GetComponent<SpriteRenderer>().sortingLayerName;
    		if(layer == player_layer){
    			Debug.Log("got flower");
    			StartCoroutine(audio_destroy());
    		}
    	}
    }
    void play_audio(){
    	if(!audio.isPlaying){
    		audio.clip = Resources.Load<AudioClip>("sfx/gender");
    		audio.Play();	
    	}
    	
    }

    IEnumerator audio_destroy(){
    	play_audio();
    	yield return new WaitForSeconds(audio.clip.length);
    	Destroy(gameObject);
    }
}
