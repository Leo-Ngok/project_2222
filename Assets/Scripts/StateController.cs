using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateController : MonoBehaviour
{
    public double LifeSpan=10;
    public float Experience=0;
    public bool User=false;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(LifeSpan<0)
        {
            if(!User)
            {
                Scenes.msg="You Win";
            }
            else
            {
                Scenes.msg="You Lose";
            }
            SceneManager.LoadScene(Scenes.End);
        }
        if(User&&Input.GetKeyDown(KeyCode.Space))
        {
            var pos_controller=this.GetComponent<PositionController>();
            var r=pos_controller.dir;
            var _bullet=Instantiate(bullet,this.transform);
            var _bulletcontrol=_bullet.GetComponent<BulletController>();
            switch(r)
            {
                case Direction.Down:
                _bulletcontrol.dir=new Vector3(0f,-1f,0f);break;
                case Direction.Up:
                _bulletcontrol.dir=new Vector3(0f,+1f,0f);break;
                case Direction.Left:
                _bulletcontrol.dir=new Vector3(-1f,0f,0f);break;
                case Direction.Right:
                _bulletcontrol.dir=new Vector3(+1f,0f,0f);break;
                default:break;
            }
            
        }
    }

}
