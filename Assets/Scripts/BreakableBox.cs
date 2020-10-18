using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBox : MonoBehaviour
{
    public GameObject breakableBox;
    public void DestroyBox()
    {
        Destroy(breakableBox);
        SoundManager.PlaySound("caixamadeiraquebrando");
    }
}
