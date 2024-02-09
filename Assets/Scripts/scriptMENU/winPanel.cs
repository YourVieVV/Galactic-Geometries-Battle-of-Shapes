using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winPanel : MonoBehaviour
{
    [SerializeField]
    private GameObject firstStartPanel;
    [SerializeField]
    private GameObject textOne;
    [SerializeField]
    private GameObject textTwo;
    [SerializeField]
    private GameObject textTree;

    [SerializeField]
    private GameObject buttonOne;
    [SerializeField]
    private GameObject buttonTwo;
    [SerializeField]
    private GameObject buttonTree;
    [SerializeField]
    private GameObject buttonFore;

    [SerializeField]
    private GameObject img;


    private void Start()
    {
            textOne.SetActive(true);
            textTwo.SetActive(false);
        textTree.SetActive(false);
        buttonTwo.SetActive(false);
        buttonTree.SetActive(false);
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

        textTwo.SetActive(false);
        buttonTwo.SetActive(false);
        textTree.SetActive(true);
        buttonTree.SetActive(true);
    }

    public void TreeClick()
    {
        textTree.SetActive(false);
        buttonTree.SetActive(false);
        img.SetActive(false);
        buttonFore.SetActive(true);
    }

    public void ForeClick()
    {
        // perexod v menu
    }
}
