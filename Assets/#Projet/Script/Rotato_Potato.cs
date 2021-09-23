using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotato_Potato : MonoBehaviour
{

    public float speed = 1f;
    private float angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        angle += Time.deltaTime * speed;
        
        transform.rotation = Quaternion.Euler(angle,0f,0f);
    }
}
