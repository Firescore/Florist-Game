using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_2_Animation : MonoBehaviour
{
    public Animator[] player;
    public void cutIn()
    {
        //player[2].SetBool("CutLoop",true);
        player[0].enabled = true;
    }
    public void cutOut()
    {
        //player[2].SetBool("CutLoop", false);
        player[0].enabled = false;
    }
}
