using TMPro;
using UnityEngine;

public class ClickerGame : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject winText;

    [SerializeField] private int score = 0;
    [SerializeField] private bool gameWon = false;

    private void OnMouseDown()
    {
        if (gameWon)
            return;

        score++;

        scoreText.text = "Score: " + score;

        if (score >= 10)
        {
            gameWon = true;
            winText.SetActive(true);
        }
    }
}