using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LA : MonoBehaviour
{
    //靜態
    //隨機 數學 輸入 時間
    // Start is called before the first frame update
    void Start()
    {
        //使用靜態屬性
        //類別名稱，靜態屬性
        print(Random.value);

        print(Mathf.PI);

        print(Mathf.Abs(199));
        print(Random.Range(50, 150));

        Debug.Log("測試~");
        Debug.LogWarning("警告!");
        Debug.LogError("危險!");

    }

    // Update is called once per frame
    private void Update()
    {
        //print(Time.time);

        //輸入靜態屬性 滑鼠座標 (0.0) Vector3
        //print(Input.mousePosition);
        //輸入 靜態方法 玩家是否按下空白建 傳回布林值方法
        //按下空白建會顯示 Ture
        //沒按空白建會顯示 False
        //print(Input.GetKeyDowm("space"));
        print(Input.GetKeyDown(KeyCode.Space));
    }
}
