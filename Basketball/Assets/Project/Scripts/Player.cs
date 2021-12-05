using UnityEngine;

public class Player : MonoBehaviour
{
  public Ball ball;
  public GameObject playerCamera;
  public float ballDistance = 2f;
  public float ballThrowingForce = 500f;

  bool holdingBall = true;

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

      if (Input.GetAxis("Fire1") > 0)
      {
        holdingBall = false;
        ball.GetComponent<Rigidbody>().useGravity = true;
        ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballThrowingForce);
        ball.ActivateTrail();
      }
    }
  }

  public bool isHoldingBall()
  {
    return holdingBall;
  }
}
