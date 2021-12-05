using UnityEngine;

public class Player : MonoBehaviour
{
  public GameObject ball;
  public GameObject playerCamera;
  public float ballDistance = 2.0f;

  void Start()
  {
    ball.GetComponent<Rigidbody>().useGravity = false;
  }

  void Update()
  {
    ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward * ballDistance;
  }
}
