using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeleteObjectonFall : MonoBehaviour
{
    [SerializeField]
    string strTag;

  private void OnCollisionEnter(Collision collision) {
      if (collision.collider.tag == strTag) {
            Destroy (gameObject);
      }
  }
}
