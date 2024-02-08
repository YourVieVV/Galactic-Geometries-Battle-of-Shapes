using System.Collections;
using UnityEngine;

public class CharOutput : MonoBehaviour
{
    private TMPro.TextMeshProUGUI TextArea;// поле вывода текста
    [SerializeField]
    private string TextDiolog;// то что будет выводится

    private void Start()
    {
        TextArea = GetComponent<TMPro.TextMeshProUGUI>();
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
