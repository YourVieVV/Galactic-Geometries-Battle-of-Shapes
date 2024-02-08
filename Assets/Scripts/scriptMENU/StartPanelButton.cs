using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPanelButton : MonoBehaviour
{
    [SerializeField]
    private GameObject firstStartPanel;
    [SerializeField]
    private GameObject textOne;
    [SerializeField]
    private GameObject textTwo;
    [SerializeField]
    private GameObject textScore;
    [SerializeField]
    private GameObject textWin;
    [SerializeField]
    private GameObject textLosses;

    [SerializeField]
    private GameObject buttonOne;
    [SerializeField]
    private GameObject buttonTwo;


    private void Start()
    {
        if ((PlayerPrefs.HasKey("FirstStartGame") == false))
        {
            firstStartPanel.SetActive(true);
            textScore.SetActive(false);
            textWin.SetActive(false);
            textLosses.SetActive(false);
            textOne.SetActive(true);
            textTwo.SetActive(false);
            buttonTwo.SetActive(false);
        }
    }
    public void FirstClick()
    {
        textOne.SetActive(false);
        textTwo.SetActive(true);
        buttonTwo.SetActive(true);
        buttonOne.SetActive(false);
    }
    public void SecondClick()
    {
        PlayerPrefs.SetInt("FirstStartGame", 0);
        firstStartPanel.SetActive(false);
        textScore.SetActive(true);
        textWin.SetActive(true);
        textLosses.SetActive(true);
    }
}
