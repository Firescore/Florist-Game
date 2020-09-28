using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scene_1_Animation : MonoBehaviour
{
    public Animator[] player;
    public TextMeshProUGUI text;
    public Slider sld;

    private void Start()
    {
        player[0].SetBool("walk", true);
    }

    private void Update()
    {
        text.text = sld.value + "/2".ToString();
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
}
