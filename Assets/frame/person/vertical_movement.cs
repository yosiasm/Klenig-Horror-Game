using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vertical_movement : MonoBehaviour
{
    public Animator animator;

    public GameObject person;
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;

    static int current_position = 0;
    static Vector3 current_scale;
    static float wait=1;
    // Start is called before the first frame update
    void Start()
    {
        current_scale = person.transform.localScale;
        change_renderer_color(0);

    }
    void change_renderer_color(int cur_pos){
    	if(cur_pos==-1){
    		for(int i = 1; i<10; i++){
    			GameObject.Find(i+"A").GetComponent<SpriteRenderer>().color = new Color(0.15f,0.15f,0.15f,1);
    			GameObject.Find(i+"B").GetComponent<SpriteRenderer>().color = new Color(0.15f,0.15f,0.15f,1);
    			GameObject.Find(i+"C").GetComponent<SpriteRenderer>().color = new Color(0.55f,0.55f,0.55f,1);
    		}
    	}else if(cur_pos==0){
    		for(int i = 1; i<10; i++){
    			GameObject.Find(i+"A").GetComponent<SpriteRenderer>().color = new Color(0.15f,0.15f,0.15f,1);
    			GameObject.Find(i+"B").GetComponent<SpriteRenderer>().color = new Color(0.55f,0.55f,0.55f,1);
    			GameObject.Find(i+"C").GetComponent<SpriteRenderer>().color = new Color(0.15f,0.15f,0.15f,1);
    		}
    	}else if(cur_pos==1){
    		for(int i = 1; i<10; i++){
    			GameObject.Find(i+"A").GetComponent<SpriteRenderer>().color = new Color(0.55f,0.55f,0.55f,1);
    			GameObject.Find(i+"B").GetComponent<SpriteRenderer>().color = new Color(0.15f,0.15f,0.15f,1);
    			GameObject.Find(i+"C").GetComponent<SpriteRenderer>().color = new Color(0.15f,0.15f,0.15f,1);
    		}
    	}
    }



    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Vertical") < 0 ){
    		if(current_position >= 0 && wait>1){
        		wait=0;
    			current_position -=1;
    			person.transform.localScale = person.transform.localScale - new Vector3(0.2f,0.2f,0);
    			person.transform.localPosition = person.transform.localPosition + new Vector3(0,1f,0);
    			light1.transform.localScale = light1.transform.localScale - new Vector3(0.2f,0.2f,0);
    			light2.transform.localScale = light2.transform.localScale - new Vector3(0.2f,0.2f,0);
    			light3.transform.localScale = light3.transform.localScale - new Vector3(0.2f,0.2f,0);
    			change_renderer_color(current_position);
    		}
    	}else if(Input.GetAxis("Vertical") > 0){

    		if(current_position <= 0  && wait>1){
    			wait=0;
    			current_position +=1;
    			person.transform.localScale = person.transform.localScale + new Vector3(0.2f,0.2f,0);
    			person.transform.localPosition = person.transform.localPosition - new Vector3(0,1f,0);
    			light1.transform.localScale = light1.transform.localScale + new Vector3(0.2f,0.2f,0);
    			light2.transform.localScale = light2.transform.localScale + new Vector3(0.2f,0.2f,0);
    			light3.transform.localScale = light3.transform.localScale + new Vector3(0.2f,0.2f,0);
    			change_renderer_color(current_position);


    		}
    	}

    	wait += 3*Time.deltaTime;

    	if(current_position == -1){ //player belakang
    		person.GetComponent<SpriteRenderer>().sortingLayerName = "player back";
    		light1.GetComponent<SpriteRenderer>().sortingLayerName = "shadow foreground";
    		light2.GetComponent<SpriteRenderer>().sortingLayerName = "shadow back";
    		light3.GetComponent<SpriteRenderer>().sortingLayerName = "shadow back";
    	}else if(current_position == 0){
    		person.GetComponent<SpriteRenderer>().sortingLayerName = "player mid";
    		light1.GetComponent<SpriteRenderer>().sortingLayerName = "shadow mid";
    		light2.GetComponent<SpriteRenderer>().sortingLayerName = "shadow foreground";
    		light3.GetComponent<SpriteRenderer>().sortingLayerName = "shadow back";
    	}else if(current_position == 1){
    		person.GetComponent<SpriteRenderer>().sortingLayerName = "player front";
    		light1.GetComponent<SpriteRenderer>().sortingLayerName = "shadow front";
    		light2.GetComponent<SpriteRenderer>().sortingLayerName = "shadow mid";
    		light3.GetComponent<SpriteRenderer>().sortingLayerName = "shadow foreground";
    	}
    }
}
