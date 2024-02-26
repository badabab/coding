using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subscriber : MonoBehaviour
{
    public string Nickmane;

    public void Watch()
    {
        Debug.Log($"{Nickmane}: 와 보러가야겠다.");
    }
    public void PostPone()
    {
        Debug.Log($"{Nickmane}: 나중에 봐야지...");
    }
}
