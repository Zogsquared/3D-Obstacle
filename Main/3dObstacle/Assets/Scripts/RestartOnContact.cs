using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnContact : MonoBehaviour
{
    [SerializeField]
    string strTag;

  private void OnCollisionEnter(Collision collision) {
      if (collision.collider.tag == strTag) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }
  }
}