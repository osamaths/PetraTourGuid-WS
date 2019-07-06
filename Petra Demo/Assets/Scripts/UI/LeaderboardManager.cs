using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardManager : MonoBehaviour {
    public Image loader;
    public Text loaderPercentage;
    int currentValue;

    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();

        loader.fillAmount = currentValue;
        loaderPercentage.text = currentValue.ToString() + "%";
    }
    public void SetLeaderboardValue(int deltaValue)
    {
        int oldValue = currentValue;
        currentValue = (currentValue + deltaValue >= 100) ? 100 : currentValue + deltaValue;
        loader.fillAmount = currentValue * 0.01f;
        loaderPercentage.text = currentValue.ToString() + "%";
    }
    public void OpenLeaderboard()
    {
        anim.SetBool("open", true);
        anim.SetBool("close", false);
    }
    public void CloseLeaderboard()
    {
        anim.SetBool("close", true);
        anim.SetBool("open", false);
    }
}
