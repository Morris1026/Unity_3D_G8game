using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 雞主席 : MonoBehaviour
{
    [Header("移動速度")][Range(1,2500)]
    public int speed = 10;
    [Header("旋轉速度")][Tooltip("雞主席的旋轉速度"),Range(1.5f  ,200f)]
    public float turn = 20.5f;
    [Header("是否完成任務")]
    public bool mission;
    [Header("玩家名稱")]
    public new string name = "雞主席";

    public Transform tran;
    public Rigidbody rig;
    public Animator ani;


    private void Update()
    {
        Turn();
        Run();
        Bark();
        Catch();
       
    }
    [Header("撿東西位置")]
    public Rigidbody rigCatch;


    private void OnTriggerStay(Collider other)
    {
        print(other.name);

        if (other.name == "蝦子" && ani.GetCurrentAnimatorStateInfo(0).IsName("吃"))
        {
            Physics.IgnoreCollision(other, GetComponent<Collider>());
            //物理 忽視碰撞

            other.GetComponent<HingeJoint>().connectedBody = rigCatch;

        }
        if (other.name == "沙子" && ani.GetCurrentAnimatorStateInfo(0).IsName("吃"))
        {
           

            GameObject.Find("蝦子").GetComponent<HingeJoint>().connectedBody = null;
        }
    }

    private void Run()
    {
        if (ani.GetCurrentAnimatorStateInfo(0).IsName("吃")) return;

        float V = Input.GetAxis("Vertical");   //W上1  S下-1  沒按=0
        //rig.Addforce(0,0,speed*v);    //世界座標
        //tran.forword  區域座標Z軸
        //tran.right    區域座標X軸
        //tran.up       區域座標Y軸
        rig.AddForce(tran.forward * speed * V * Time.deltaTime);

        ani.SetBool("走路切換", V != 0);

    }

    private void Turn()
    {
        float h = Input.GetAxis("Horizontal");   //A=左 -1  D=右 1  沒按=0  
        tran.Rotate(0, turn * h * Time.deltaTime, 0);
    }

    private void Bark()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ani.SetTrigger("拍翅膀");
        }
    }

    private void Catch()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ani.SetTrigger("吃");
        }
    }

    private void Task()
    {

    }
}
