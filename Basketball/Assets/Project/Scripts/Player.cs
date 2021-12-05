using UnityEngine;

public class Player : MonoBehaviour
{
  public GameObject ball;
  public GameObject playerCamera;
  public float ballDistance = 2f;
  public float ballThrowingForce = 500f;

  private bool holdingBall = true;

  void Start()
  {
    ball.GetComponent<Rigidbody>().useGravity = false;
  }

  void Update()
  {
    if (holdingBall)
    {
      ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward * ballDistance;
      ball.transform.rotation = playerCamera.transform.rotation;

      if (Input.GetMouseButtonDown(0))
      {
        holdingBall = false;
        ball.GetComponent<Rigidbody>().useGravity = true;
        ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballThrowingForce);
      }
    }
  }
}
