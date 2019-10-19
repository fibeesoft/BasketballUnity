using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionBtnRotate : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Animation anim;
    [SerializeField] Animator animator;
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        animator = gameObject.GetComponent<Animator>();
        animator.SetBool("isRotating", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RotateTheCog()
    {
        animator.SetBool("isRotating", true);
        if(animator.GetBool("isRotating") == true)
        {
            anim.Play("CogWheelAnim");
            animator.SetBool("isRotating", false);
        }
        
        print("rotate");
    }
}
