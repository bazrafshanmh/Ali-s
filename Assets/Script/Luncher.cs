using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Luncher : MonoBehaviour
{
    public Sprite MySprite;
    void Start()
    {
        if (!ChangeKnifeSkin.KnifeSkin)
        {
        ChangeKnifeSkin.KnifeSkin = MySprite;
        }
    }
    public void OnClick()
    {
        SceneManager.LoadScene("menu");
    }
    public void OnClickResume()
    {
        SceneManager.LoadScene("game");
        GameManager.ChangeState("ReTry");
    }
    public void OnClickShop()
    {
        SceneManager.LoadScene("shopPage");
    }
    public void OnClickExit()
    {
        SceneManager.LoadScene("play");
    }

}