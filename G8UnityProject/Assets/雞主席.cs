using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 雞主席 : MonoBehaviour
{
    [Header("移動速度")][Range(1,100)]
    public int speed = 10;
    [Tooltip("雞主席的旋轉速度"),Range(1.5f  ,200f)]
    public float turn = 20.5f;
    public bool mission;
    public string name = "雞主席";

}
