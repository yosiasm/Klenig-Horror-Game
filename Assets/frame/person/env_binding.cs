using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class env_binding : MonoBehaviour
{
	public float accelerator_size;
	public float accelerator_sizeC;
	public float paddingB;
	public float paddingC;
    
    void Update()
    {
        for(int i = 1 ; i<=9 ; i++){
        	//mid[i].transform.position = pivot[i].transform.positon + new Vector3d(0,0,0); //add gyroscope
        	//background[i].transform.position = pivot[i].transform.positon + new Vector3d(0,0,0); //add gyroscope
        	Vector3 accB  = new Vector3 (Input.acceleration.x*accelerator_size, Input.acceleration.y*accelerator_size +accelerator_size,0);
        	Vector3 accC  = new Vector3 (Input.acceleration.x*accelerator_sizeC, Input.acceleration.y*accelerator_sizeC +accelerator_sizeC,0);
        	GameObject.Find(i+"B").transform.position = GameObject.Find(i+"A").transform.position*paddingB + accB; //add gyroscope//mid
        	
        	GameObject.Find(i+"C").transform.position = GameObject.Find(i+"A").transform.position*paddingC + accC; //add gyroscope//mid
        }
    }
}
