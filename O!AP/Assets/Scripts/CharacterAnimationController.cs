using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Assuming the animator component is attached to the same GameObject as this script
        animator = GetComponent<Animator>();
    }

    public void UpdateAnimation(Vector2 direction)
    {
        if (direction != Vector2.zero)
        {
            SetAnimationDirection(direction);
        }
        else
        {
            SetIdleAnimation();
        }
    }

    private void SetAnimationDirection(Vector2 move)
    {
        if (move.x > 0 && move.y > 0)
        {
            animator.SetFloat("Direction", 1); // Up-Right
        }
        else if (move.x < 0 && move.y > 0)
        {
            animator.SetFloat("Direction", 0); // Up-Left
        }
        else if (move.x < 0 && move.y < 0)
        {
            animator.SetFloat("Direction", 2); // Down-Left
        }
        else if (move.x > 0 && move.y < 0)
        {
            animator.SetFloat("Direction", 3); // Down-Right
        }
    }

    private void SetIdleAnimation()
    {
        // Set the animator's Direction parameter to its current value
        animator.SetFloat("Direction", animator.GetFloat("Direction"));
    }
}
