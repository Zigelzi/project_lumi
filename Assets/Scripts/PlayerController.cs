using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerHealth = 100.0f;
    private Animator animator;

    [SerializeField] private float attackDamage = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack1Trigger");
        }   
    }
}
