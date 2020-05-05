using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControls : MonoBehaviour
{
    public Animator myAnimator;

    Vector2 speed;

    void Start()
    {
        
    }

    void Update()
    {
        speed.x = Input.GetAxisRaw("Vertical");

        myAnimator.SetFloat("Speed", speed.x);
        myAnimator.SetFloat("speedNormalized", Mathf.Abs(speed.x));
    }
}
