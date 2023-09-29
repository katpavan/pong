using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public int _playerScore;
    public int _computerScore;
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;

    [SerializeField] TextMeshProUGUI playerScore;
    [SerializeField] TextMeshProUGUI computerScore;
    public static GameManager Instance { get; private set; } // private to set it, anyone can get it

    public void Awake()
    {
        if (Instance != null && Instance != this)
        { 
            Destroy(this); 
        } else 
        { 
            Instance = this; 
        }
    }

    public void PlayerScores()
    {
        _playerScore++;
        playerScore.text = _playerScore.ToString();
        ResetRound();
    }

    public void ComputerScores()
    {
        _computerScore++;
        computerScore.text = _computerScore.ToString();
        ResetRound();
    }

    public void ResetRound()
    {
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
    }

}