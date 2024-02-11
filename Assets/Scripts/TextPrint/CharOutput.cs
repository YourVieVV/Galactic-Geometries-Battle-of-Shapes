using System.Collections;
using UnityEngine;

public class CharOutput : MonoBehaviour
{
    private TMPro.TextMeshProUGUI TextArea;// поле вывода текста
    [SerializeField]
    private string TextEn;// то что будет выводится
    [SerializeField]
    private string TextRu;// то что будет выводится

    private string TextDiolog;


    private void Start()
    {
        TextArea = GetComponent<TMPro.TextMeshProUGUI>();
        if (PlayerPrefs.GetString("Lang") == "ru")
        {
            TextDiolog = TextRu;
        }
        else
        {
            TextDiolog = TextEn;
        }
            StartCoroutine(TextAnimation());
    }
    private IEnumerator TextAnimation()
    {
        foreach (var charText in TextDiolog)
        {
            TextArea.text += charText;

            yield return new WaitForSeconds(0.06f);// время для вывода след. буквы
        }
    }
}
