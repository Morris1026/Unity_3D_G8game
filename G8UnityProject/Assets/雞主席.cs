using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 雞主席 : MonoBehaviour
{
    [Header("移動速度")][Range(1,2500)]
    public int speed = 10;
    [Tooltip("雞主席的旋轉速度"),Range(1.5f  ,200f)]
    public float turn = 20.5f;
    public bool mission;
    public string _name = "雞主席";

    public Transform tran;
    public Rigidbody rig;
    public Animation ani;


    private void Update()
    {
        Turn();
        Run();
        Bark();
        Catch();
        Task();
    }

    private void Run()
    {
        float V = Input.GetAxis("Vertical");   //W上1  S下-1  沒按=0
        //rig.Addforce(0,0,speed*v);    //世界座標
        //tran.forword  區域座標Z軸
        //tran.right    區域座標X軸
        //tran.up       區域座標Y軸
        rig.AddForce(tran.forward * speed * V * Time.deltaTime);
    }

    private void Turn()
    {
        float h = Input.GetAxis("Horizontal");   //A=左 -1  D=右 1  沒按=0  
        tran.Rotate(0, turn * h * Time.deltaTime, 0);
    }

    private void Bark()
    {

    }

    private void Catch()
    {

    }

    private void Task()
    {

    }
}
