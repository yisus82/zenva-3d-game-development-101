using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
  public Player player;
  public float resetTimeDelay = 5f;

  void Update()
  {
    if (!player.isHoldingBall())
    {
      resetTimeDelay -= Time.deltaTime;
      if (resetTimeDelay <= 0)
      {
        resetTimeDelay = 5f;
        SceneManager.LoadScene("MainScene");
      }
    }
  }
}
