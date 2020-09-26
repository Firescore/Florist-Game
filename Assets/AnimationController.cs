using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator[] player;

    private void Start()
    {
            player[3].enabled = false;
            player[4].enabled = false;
            player[5].enabled = false;
    }
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
        //player[2].SetBool("CutLoop",true);
            player[2].enabled = true;
    }
    public void cutOut()
    {
        //player[2].SetBool("CutLoop", false);
            player[2].enabled = false;
    }
    public void leftFold()
    {
            player[3].enabled = true;
    }
    public void rightFold()
    {
            player[4].enabled = true;
    }
    public void downFold()
    {
            player[5].enabled = true;
    }
}
