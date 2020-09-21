using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator[] player;

    public void idlePlayer()
    {
        player[0].SetBool("idle", true);
    }
}
