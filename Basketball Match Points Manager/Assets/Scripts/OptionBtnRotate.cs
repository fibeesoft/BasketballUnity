using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionBtnRotate : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    public void RotateTheCog()
    {
        anim.SetTrigger("RotateCog");
    }
}
