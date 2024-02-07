using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text textScore;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        textScore = GetComponent<Text>();
    }

    public void CounterScope(int count)
    {
        score += count;
        textScore.text = $"Scope: {score}";
    }
}
