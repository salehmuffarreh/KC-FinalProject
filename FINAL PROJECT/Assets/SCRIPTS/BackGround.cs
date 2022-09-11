using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    private float lengeth, startpos;
    public GameObject cam;
    public float parallaxEffect;
   
    void Start()
    {
        startpos = transform.position.x;
        lengeth=GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        float dist = (cam.transform.position.x * parallaxEffect);

        transform.position= new Vector3(startpos+dist,transform.position.y,transform.position.z);
    }
}
