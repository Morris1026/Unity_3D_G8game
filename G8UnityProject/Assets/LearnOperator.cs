
using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int A = 10, B = 3;
    public int C = 1;
    public int D = 1, E = 1;
    public int F = 10;

    public float G = 1.5f, H = 99.9f;

    public float hp = 70;
    public bool key;
    public int enemy;
    public void Start()
    {
        #region 數學運算子
        print(A + B);
        print(A - B);
        print(A * B);
        print(A / B);
        print(A % B);

        C = 99 + 1;
        print(C);

        C = C + 1;

        print(D++);
        print(++E);

        F += 100;
        print(F);
        #endregion

        #region 比較運算子
        print(G > H);
        print(G < H);
        print(G >= H);
        print(G <=H);
        print(G ==H);
        print(G !=H);
        #endregion
   
        #region 邏輯運算子
        print(true && true);
        print(true && false);
        print(false && true);
        print(false && false);

        print(true || true);
        print(true || false);
        print(false || true);
        print(false || false);

        print(!true);
        print(!false);


        #endregion
    }

    private void Update()
    {
        print("死亡 : " +(hp= 0));

        print("過關:" + (key || enemy >= 5));
    }
}
