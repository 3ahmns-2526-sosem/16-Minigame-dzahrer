using TMPro;
using UnityEngine;

public class ClickerGame : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    [SerializeField] private int score = 0;

    private void OnMouseDown()
    {
        score++;

        scoreText.text = "Score: " + score;
    }
}