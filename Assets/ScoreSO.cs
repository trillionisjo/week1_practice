using UnityEngine;

[CreateAssetMenu(fileName = "Score", menuName = "ScriptableObject/Score")]
public class ScoreSO : ScriptableObject {
	public int currentScore;
	public int highScore;
}
