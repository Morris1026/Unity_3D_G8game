
using UnityEngine;

public class LearnIF : MonoBehaviour
{
    public bool openDoor;
    public int score;

    private void Start()
    {
        if(true)
        {
            print("測試!");
        }
    }


   private void update()

    {
        if (openDoor)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }
        if (score > 60)
        {
            print("及格");
        }
        else if (score >= 50) 
        {
            print("可以花錢補考ㄛ~~~");
        }
        else if (score >= 40) 
        {
            print("被當ㄌㄌㄌㄌ");
        }
    }
}
