using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bot_agent : MonoBehaviour
{
 // Start is called before the first frame update
    public string env;
    public string behaviour;
    public string layer;
    AudioSource audio;
    void Start()
    {
    	audio = gameObject.GetComponent<AudioSource>();
    	random_env = Random.Range(2,10)+"A";
    	if(env=="1B"){
    			env = random_env;
    	}

        movement =new Vector3(0,-0.1f,0);
        
        transform.position = GameObject.Find(env).transform.position;
    	minimum = Random.Range(-6, -4);
    	maximum = -minimum;

    }

    Vector3 movement;
    static float minimum = -4.0F;
    static float maximum =  4.0F;
    float ran_speed = 1.5f;
    float t = 0.00f;
    float fade=1;
    float speed = 0.3f;
    bool chase = true;

    string random_env;
    string player_layer;
    void Update()
    {
    	t += speed * Time.deltaTime;
    	player_layer = GameObject.Find("player").GetComponent<SpriteRenderer>().sortingLayerName;
    	check_kena();
    	if(behaviour == "random" ){
    		

    		if (t > Random.Range(1f, 3f))
	        {
	            ran_speed = ran_speed * -1f;
	            t=0f;

	        }
    		movement = movement + (Vector3.right * ran_speed * Time.deltaTime);

        	transform.position = GameObject.Find(env).transform.position+movement;
        	// transform.Translate(Vector3.right * ran_speed * Time.deltaTime);

        	float jarak = transform.position.x;
	        if(jarak<5f && jarak>-5f){
	        	play_audio();
	        }
    	}else if(behaviour == "teleport"){
    		if (t > 1.0f){
    			fade -= 0.8f * Time.deltaTime;
    			gameObject.GetComponent<SpriteRenderer>().color = new Color(0.55f,0.55f,0.55f,fade);
    			if(fade<0){
    				t = 0f;
	    			fade=1;

    				random_env = Random.Range(1,10)+"A";
	    			movement = new Vector3(Random.Range(-3,4), -0.1f, 0);
    				gameObject.GetComponent<SpriteRenderer>().color = new Color(0.55f,0.55f,0.55f,fade);
    			}
    			
    		}
    		transform.position = GameObject.Find(random_env).transform.position + movement;

    		float jarak = transform.position.x;
	        if(jarak<5f && jarak>-5f && layer==player_layer){
	        	play_audio();
	        }
    		
    	}else if(behaviour == "train"){
    		
    		// movement = new Vector3(Mathf.Lerp(minimum, maximum, t), -0.1f, 0);
	    	movement = movement + (Vector3.right * ran_speed * Time.deltaTime);

    		
	        float jarak = transform.position.x;
	        if(jarak<8f && jarak>-8f  && layer==player_layer){
	        	play_audio();
	        	// transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, 0.09f* Time.deltaTime);
	        	transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, 7f* Time.deltaTime);
	        }else{
	        	// transform.position = GameObject.Find(env).transform.position + movement;

	        	transform.position = GameObject.Find(env).transform.position+movement;
	        	
	        }

	     //    if (t > 1.0f)
		    // {
		    //     float temp = maximum;
		    //     maximum = minimum;
		    //     minimum = temp;
		    //     t = 0.0f;
		    // }
		    if (t > 3f)
		    {
		        ran_speed = ran_speed * -1f;
		        t=0f;

		    }
    	}else if(behaviour== "ngejarlambat"){
    		if (t > 2.0f){
		        t = 0.0f;
		        chase = !chase;
		        // transform.position = GameObject.Find(random_env).transform.position;
		        // movement = transform.position;
		    }
    		
	        float jarak = transform.position.x;
	        if(jarak<6f && jarak>-6f && chase){
	        	play_audio();
	        	Debug.Log("chasing slow");
	        	// transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, 0.007f* Time.deltaTime);
	        	// transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, 0.25f* Time.deltaTime);
	        	movement = transform.position - GameObject.Find(env).transform.position;
	        	if(jarak < 0) transform.Translate(Vector3.right * 0.25f * Time.deltaTime);
	        	else transform.Translate(Vector3.left * 0.25f * Time.deltaTime);
	        	gameObject.GetComponent<SpriteRenderer>().sortingLayerName = player_layer;
	        	layer = player_layer;
	        }else{
	        	transform.position =  GameObject.Find(env).transform.position + movement;
	        	
	        }
    	}else if(behaviour == "teleport2"){
    		if (t > 0.8f){
    			fade -= 1f * Time.deltaTime;
    			gameObject.GetComponent<SpriteRenderer>().color = new Color(0.55f,0.55f,0.55f,fade);
    			if(fade<0){
    				t = 0f;
	    			fade=1;

    				random_env = Random.Range(1,10)+"A";
	    			movement = new Vector3(Random.Range(-3,4), -0.1f, 0);
    				gameObject.GetComponent<SpriteRenderer>().color = new Color(0.55f,0.55f,0.55f,fade);
    			}
    			
    		}
    		transform.position = GameObject.Find(random_env).transform.position + movement;

    		float jarak = transform.position.x;
	        if(jarak<5f && jarak>-5f){
	        	play_audio();
	        }
    		
    	}else if(behaviour== "ngejarcepat"){
    		if (t > 1.5f){
		        t = 0.0f;
		        chase = !chase;
		        // transform.position = GameObject.Find(random_env).transform.position;
		        // movement = transform.position;
		    }
    		
	        float jarak = transform.position.x;
	        if(jarak<8f && jarak>-8f && chase){
	        	play_audio();
	        	Debug.Log("chasing fast");
	        	// transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, 0.01f* Time.deltaTime);
	        	// transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, 0.5f* Time.deltaTime);
	        	movement = transform.position - GameObject.Find(env).transform.position;
	        	if(jarak < 0) transform.Translate(Vector3.right * 0.5f * Time.deltaTime);
	        	else transform.Translate(Vector3.left * 0.5f * Time.deltaTime);
	        	gameObject.GetComponent<SpriteRenderer>().sortingLayerName = player_layer;
	        	layer = player_layer;
	        }else{
	        	transform.position =  GameObject.Find(env).transform.position + movement;
	        	
	        }
    	}
    	else{
    		transform.position = GameObject.Find(env).transform.position;
    	}
    }

    void check_kena(){
    	float x = transform.position.x;
    	if(x < 0.5f && x > -0.5f){
    		if(layer == player_layer){
    			Debug.Log("kalah");
    			GameObject.Find("player").GetComponent<Animator>().SetBool("shocked", true);
    			GameObject.Find("hans1").transform.position = Vector3.zero;
    		}
    	}
    }
    void play_audio(){
    	if(!audio.isPlaying){
    		audio.clip = Resources.Load<AudioClip>("sfx/"+behaviour);
    		audio.Play();	
    	}
    	
    }
}
