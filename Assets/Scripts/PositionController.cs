using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionController : MonoBehaviour
{
    public bool ByUser=false;
    public Direction dir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos=this.transform.position;
        float x0=pos.x;
        float y0=pos.y;
        float z0=pos.z;
        float dt=0.02f;
        if(ByUser)
        {
            
            if(Input.GetKey(KeyCode.DownArrow)
            ||Input.GetKey(KeyCode.S))
            {
                dir=Direction.Down;
                if(Assert_Pos(x0,y0-dt))
                {
                    pos=new Vector3(x0,y0-dt,z0);
                }
            }
            if(Input.GetKey(KeyCode.UpArrow)
            ||Input.GetKey(KeyCode.W))
            {
                dir=Direction.Up;
                if(Assert_Pos(x0,y0+dt))
                {
                    pos=new Vector3(x0,y0+dt,z0);
                }
            }
            if(Input.GetKey(KeyCode.LeftArrow)
            ||Input.GetKey(KeyCode.A))
            {
                dir=Direction.Left;
                if(Assert_Pos(x0-dt,y0))
                {
                    pos=new Vector3(x0-dt,y0,z0);
                }
            }
            if(Input.GetKey(KeyCode.RightArrow)
            ||Input.GetKey(KeyCode.D))
            {
                dir=Direction.Right;
                if(Assert_Pos(x0+dt,y0))
                {
                    pos=new Vector3(x0+dt,y0,z0);
                }
            }
        }
        else
        {

        }
        this.transform.position=pos;
    }
    bool Assert_Pos( float x,float y)
    {
        if(x*x<=100&&y*y<=25)return true;
        return false;
    }
}
