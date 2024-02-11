using System.Collections;
using UnityEngine;

public class CharOutput : MonoBehaviour
{
    private TMPro.TextMeshProUGUI TextArea;// ���� ������ ������
    [SerializeField]
    private string TextEn;// �� ��� ����� ���������
    [SerializeField]
    private string TextRu;// �� ��� ����� ���������

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

            yield return new WaitForSeconds(0.06f);// ����� ��� ������ ����. �����
        }
    }
}
