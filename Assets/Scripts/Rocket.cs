using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Rocket : MonoBehaviour
{
    [SerializeField] ScoreSO score;

    private Rigidbody2D _rb2d;
    private float fuel = 100f;
    
    private readonly float SPEED = 150f;
    private readonly float FUELPERSHOOT = 10f;

    public int CurrentScore => score.currentScore;
    public int HighScore => score.highScore;
    public float Fuel => fuel;
    
    void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        // TODO : Rigidbody2D 컴포넌트를 가져옴(캐싱) 
    }

    private void Update () {
        if (fuel <= 100f) {
            fuel += 0.1f;
        } else {
            fuel = 100f;
        }

        score.currentScore = (int)transform.position.y;
        score.highScore = Mathf.Max(score.highScore, score.currentScore);
    }

    public void Shoot()
    {
        // TODO : fuel이 넉넉하면 윗 방향으로 SPEED만큼의 힘으로 점프, 모자라면 무시
        if (fuel - FUELPERSHOOT <= 0f) {
            return;
        }
        _rb2d.AddForce(Vector2.up * SPEED);
        fuel -= FUELPERSHOOT;
    }

    public void RestartGame () {
        SceneManager.LoadScene("RocketLauncher");
    }
}
