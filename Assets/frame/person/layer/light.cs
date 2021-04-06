using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lig;
    static Vector3 scale1;

    public float scalerspeed = 10.0f;
    public float size;
    static float maximum;
    static float minimum;
    static float t = 0f;
    void Start()
    {
    	scale1 = lig.transform.localScale;
    	maximum = size;
    	minimum = -size;
    }

    // Update is called once per frame
    void Update()
    {
    	Vector3 scaled = new Vector3(Mathf.Lerp(minimum, maximum, t),Mathf.Lerp(minimum, maximum, t),0);
        transform.localScale = scale1 + scaled;

        t += scalerspeed * Time.deltaTime;
        if (t >size || t < -size)
        {
            float temp = maximum;
            maximum = minimum;
            minimum = temp;
            t = 0.0f;
        }

    }
}
