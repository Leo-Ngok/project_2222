using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 dir;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position+=dir*0.05f;
        float x=this.transform.position.x;
        float y=this.transform.position.y;
        if(!Assert_Pos(x,y))
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        var prof=collider.GetComponent<StateController>();
        prof.LifeSpan-=1.5;
        Debug.Log(prof.LifeSpan);
        Destroy(this.gameObject);
    }
    bool Assert_Pos( float x,float y)
    {
        return (x*x<=100&&y*y<=25);
    }
}
