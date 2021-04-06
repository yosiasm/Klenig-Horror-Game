using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appear : MonoBehaviour
{
    public List<GameObject> envs = new List<GameObject>();
    static Sprite[] sprites;
    static List<GameObject> hantus = new List<GameObject>();
    static int jumlah_hantu = 9;

    static void spawn_hantu(int level){
    	for(int i = 0; i< jumlah_hantu; i++){

    		GameObject hantu = new GameObject("hantu"+i);
    		hantu.AddComponent<SpriteRenderer>();
    		string layer = random_layer();
    		hantu.GetComponent<SpriteRenderer>().sortingLayerName = layer;
    		hantu.transform.localScale = new Vector3(0.7f,0.7f,0.7f);
    		hantu.GetComponent<SpriteRenderer>().color = new Color(0.55f,0.55f,0.55f,1);

    		hantu.AddComponent<AudioSource>();

    		hantu.AddComponent<bot_agent>();
    		hantu.GetComponent<bot_agent>().env = Random.Range(2,10)+"A";
    		hantu.GetComponent<bot_agent>().layer = layer;

    		
    		string jenis = jenis_hantu(level);
    		hantu.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("hanss/"+jenis);
    		hantu.GetComponent<bot_agent>().behaviour = jenis;
    		hantu.name = jenis;

    		// hantus.Add(hantu);
    	}
    }
    static string random_layer(){
    	int random = Random.Range(0,3);
    	if(random==0){
    		return "player back";
    	}else if(random==1){
    		return "player mid";
    	}else{
    		return "player front";
    	}
    }

    static string jenis_hantu(int level){
    	int random = Random.Range(0,level);
    	if(random==0){
    		return "random";
    	}else if(random==1){
    		return "train";
    	}else if(random==2){
    		return "teleport";
    	}else if(random==3){
    		return "ngejarlambat";
    	}else if(random==4){
    		return "teleport2";
    	}else if(random==5){
    		return "ngejarcepat";
    	}else{
    		return "random";
    	}
    }





    void spawn_flower(int level){
    	for(int i = 0; i< level+3; i++){

    		GameObject flower = new GameObject("flower"+i);
    		flower.AddComponent<SpriteRenderer>();
    		string layer = random_layer();
    		flower.GetComponent<SpriteRenderer>().sortingLayerName = layer;
    		flower.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
    		flower.GetComponent<SpriteRenderer>().color = new Color(0.66f,0.66f,0.66f,1);
    		string env = Random.Range(2,10)+"A";
    		flower.AddComponent<flo_spawn>();
    		flower.GetComponent<flo_spawn>().env = env;
    		flower.GetComponent<flo_spawn>().layer = layer;
    		flower.AddComponent<AudioSource>();

    		
    		flower.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("flo/b");
    		flower.name = env+layer+i;

    		// hantus.Add(hantu);
    	}
    }
    void Start()
    {
    	// sprites = Resources.LoadAll<Sprite>("hanss/");
    	spawn_hantu(6);
    	// spawn_hantu(6);
    	spawn_flower(9);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
