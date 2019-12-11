using UnityEngine;

public class LearnPA : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform test1;
    public Transform test2;

    private void Start()
    {
        print(test1.position);

        test1.localScale = new Vector3(10, 10, 10);

        test2.localScale = Vector3.one * 5;

    }

    private void Update()
    {
        test1.Rotate(0, 5, 0);
        test2.Translate(0, 0, 1.5f);
    }
}
