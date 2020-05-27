using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && animator.GetBool("isOpen"))
        {
            animator.SetBool("isOpen", false);
        } else if (Input.GetMouseButtonDown(0) && !animator.GetBool("isOpen")) {
            animator.SetBool("isOpen", true);
        }
        
    }
}
