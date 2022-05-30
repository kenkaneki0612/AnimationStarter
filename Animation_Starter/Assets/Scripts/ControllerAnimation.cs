using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerAnimation : MonoBehaviour
{
    public void OpenAnimation (Animator animator)
    {
        animator.SetBool("visible", true);
    }

    public void CloseAnimation (Animator animator)
    {
        animator.SetBool("visible", false);
    }

    public void OpenButton (Animator animator)
    {
        animator.SetBool("checkopen", true);
    }

    public void CloseButton (Animator animator)
    {
        animator.SetBool("checkclose", true);
    }
}
