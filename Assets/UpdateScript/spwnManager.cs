﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwnManager : MonoBehaviour
{
    public static spwnManager spwn;
    public levelManager lv;
    public GameObject[] Scene; 
    public GameObject OldScene,nextLv;
    int i = 0;
    int level = 0;

    private void Start()
    {
        spwn = this;
    }
    public void play()
    {
        level = 1;
        levelManager.levelMan.levelText.text = "Level " + level.ToString();
        OldScene = Instantiate(Scene[0], transform.position, Quaternion.identity);
        OldScene.transform.parent = nextLv.transform;
    }
    public void next()
    {
        StartCoroutine(nextANI());
    }
    IEnumerator nextANI()
    {

            foreach (Transform child in nextLv.transform)
            {
                GameObject.Destroy(child.gameObject);
            }
        yield return new WaitForSeconds(0.5f);
        lv.gameOver = false;
        lv.nextButton.SetActive(false);
            i = Random.Range(0, 5);
            level += 1;
            levelManager.levelMan.levelText.text = "Level " + level.ToString();
            if (level == 2)
            {
                OldScene = Instantiate(Scene[1], transform.position, Quaternion.identity);
                OldScene.transform.parent = nextLv.transform;
            }
            else if (level == 3)
            {
                OldScene = Instantiate(Scene[2], transform.position, Quaternion.identity);
                OldScene.transform.parent = nextLv.transform;
            }
            else if (level == 4)
            {
                OldScene = Instantiate(Scene[3], transform.position, Quaternion.identity);
                OldScene.transform.parent = nextLv.transform;
            }
            else if (level == 5)
            {
                OldScene = Instantiate(Scene[4], transform.position, Quaternion.identity);
                OldScene.transform.parent = nextLv.transform;
            }
            else if (level >= 6)
            {
                OldScene = Instantiate(Scene[i], transform.position, Quaternion.identity);
                OldScene.transform.parent = nextLv.transform;
            }
        
    }
}