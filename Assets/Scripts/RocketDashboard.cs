using TMPro;
using UnityEngine;

public class RocketDashboard : MonoBehaviour {
    [SerializeField] TextMeshProUGUI currentScoreText;
    [SerializeField] TextMeshProUGUI hightScoreText;

    private Rocket rocket;

    private void Awake () {
        rocket = GetComponent<Rocket>();
    }

    private void Update () {
        currentScoreText.text = $"{rocket.CurrentScore} M";
        hightScoreText.text = $"HIGH : {rocket.HighScore} M";
    }
}
