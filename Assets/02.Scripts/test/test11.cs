using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test11 : MonoBehaviour
{
    public int H, M;
    // 0 ¡Â H ¡Â 23, 0 ¡Â M ¡Â 59

    void Start()
    {
        int H2, M2;
        if (M >= 45)
        {
            M2 = M - 45;
            Debug.Log($"{H} {M2}");
        }
        
        else // (M < 45)
        {
            H2 = H - 1;
            if (H2 < 0)
            {
                H2 = H + 23;
            }
            M2 = M + 60 - 45;
            Debug.Log($"{H2} {M2}");
        }
    }
}
