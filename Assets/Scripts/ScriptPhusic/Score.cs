using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text textScore;
    private float scope = 0;
    // Start is called before the first frame update
    void Start()
    {
        textScore = GetComponent<Text>();
    }

    public void CounterScope(float count)
    {
        scope += count;
        textScore.text = $"Scope: {scope}";
    }
}
