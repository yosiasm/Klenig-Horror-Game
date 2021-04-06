using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class broken_lamp : MonoBehaviour
{
	bool first = true;
   	void Start(){
    	StartCoroutine("DoStuff", 30.0F);
	}
	bool someStopFlag=false;
	IEnumerator DoStuff(float waitTime) {
	    while(true){
	        Debug.Log("lamp broke");
	        if(first != true){
	        	GameObject.Find("light").transform.localScale = new Vector3(3,3,3);
	        }else{
	        	first = false;
	        }
	        if(someStopFlag==true)yield break;
	        else yield return new WaitForSeconds(waitTime);
	    }
	}

    // Update is called once per frame
    void Update()
    {
    	if (Input.GetKeyDown(KeyCode.Space))
        {
            print("space key was pressed");
            Vector3 scale = GameObject.Find("light").transform.localScale;
            if(scale.x < 13.5f){
            	GameObject.Find("light").transform.localScale = scale + new Vector3(0.5f,0.5f,0.5f);
            }
        }
        
    }

    
}
