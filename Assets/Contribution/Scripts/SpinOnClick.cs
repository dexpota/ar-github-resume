using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinOnClick : MonoBehaviour
{
    private Animator animator;
    private static readonly int Spin = Animator.StringToHash("Spin");

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0)) {
            animator.SetTrigger(Spin);
        }
            
    }
}
