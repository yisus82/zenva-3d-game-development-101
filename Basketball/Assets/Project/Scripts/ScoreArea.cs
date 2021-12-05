using UnityEngine;

public class ScoreArea : MonoBehaviour
{
  public GameObject effectObject;

  void Start()
  {
    effectObject.SetActive(false);
  }

  void OnTriggerEnter(Collider other)
  {
    if (other.GetComponent<Ball>() != null)
    {
      effectObject.SetActive(true);
    }
  }
}
