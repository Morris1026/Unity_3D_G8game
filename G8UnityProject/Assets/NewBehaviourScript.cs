using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void Drive(int speed)
    {
        print("音效~");

        print("開車，時速:"+speed);
    }
    public void Shoot(int count,float speed,string prop = "無",string direction = "前方")
    {
        print("弓箭數量:" + count);
        print("弓箭速度:" + speed);
        print("弓箭屬性:" + prop);
        print("弓箭方向:" + direction);
    }
    

    private int Square(int number = 2)
    {
        return number * number;
    }

    // Update is called once per frame
    private void Start()
    {
        print("哈樓~");

        Drive(200);
        Drive(300);
        Drive(400);

        Shoot(1, 5.1f);
        Shoot(10, 10.5f);
        Shoot(3, 2, direction: "前後方");


        print(Square());

        int result = Square(9);
        print(result);

    }
} 