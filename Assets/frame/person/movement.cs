using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
	public float padding = 1.37f;
    public Animator animator;
    public List<GameObject> sprites = new List<GameObject>();

    static GameObject pop(List<GameObject> sprites, int index){
    	GameObject ret = sprites[index];
    	sprites.RemoveAt(index);
    	return ret;
    }

    bool lamp(){
        float x = GameObject.Find("light").transform.localScale.x;
        return (x < 13.3f);
    }
    // Update is called once per frame
    void Update()
    {
        if(lamp()){
            animator.SetBool("pump_steady", true);
            animator.SetBool("forward", false);
            animator.SetBool("backward", false);
        }else if(Input.GetAxis("Horizontal") < 0){
    		animator.SetBool("backward", true);
            animator.SetBool("pump_steady", false);
    		animator.SetBool("forward", false);
    	}else if(Input.GetAxis("Horizontal") > 0){
    		animator.SetBool("forward",true);
            animator.SetBool("pump_steady", false);
    		animator.SetBool("backward", false);
    	}else if(Input.GetAxis("Vertical") > 0){
            animator.SetBool("forward",true);
            animator.SetBool("pump_steady", false);
            animator.SetBool("backward", false);
        }else if(Input.GetAxis("Vertical") < 0 ){
            animator.SetBool("backward", true);
            animator.SetBool("pump_steady", false);
            animator.SetBool("forward", false);
        }else{
    		animator.SetBool("forward", false);
            animator.SetBool("pump_steady", false);
    		animator.SetBool("backward", false);
    	}
    	//first sprite walk backward
		if(sprites[sprites.Count - 1].transform.position.x < 45){
			GameObject first = pop(sprites, 0);
			float x = (float)first.GetComponent<SpriteRenderer>().size.x * padding;
			first.transform.position = sprites[sprites.Count - 1].transform.position + new Vector3(x,0,0);
			sprites.Add(first);
		}
		//last sprite walk forward
		else if(sprites[0].transform.position.x > - 45){
			GameObject last = pop(sprites, sprites.Count - 1);
			float x = (float)last.GetComponent<SpriteRenderer>().size.x * padding;
			last.transform.position = sprites[0].transform.position - new Vector3(x,0,0);
			sprites.Insert(0,last);
		}
		Vector3 horizontal =  new Vector3(Input.GetAxis("Horizontal"),0,0);
        if(lamp()) horizontal = Vector3.zero;
		foreach(GameObject sprite in sprites){
			sprite.transform.position = sprite.transform.position - horizontal * Time.deltaTime*2.6f;
		}
    	// Debug.Log(sprites[sprites.Count - 1].transform.position.x);
    	
    	//transform.position = transform.position - horizontal * Time.deltaTime; 
        
    }
}
