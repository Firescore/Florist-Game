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

    public void grabIn()
    {
        player[1].SetBool("Grab", true);
    }

    public void grabOut()
    {
        player[1].SetBool("Grab", false);
    }

    public void cutIn()
    {
        player[2].SetBool("CutLoop",true);
    }
    public void cutOut()
    {
        player[2].SetBool("CutLoop", false);
    }
}
