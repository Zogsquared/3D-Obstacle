using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField]
    string strTag;
    float time;
    public UIController theHighScore;
    //public UIController1 theHighScore1;

  private void OnCollisionEnter(Collision collision) {
      if (collision.collider.tag == strTag) {
            theHighScore.SetHighScore(time);
            //theHighScore1.SetHighScore(time);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }
  }

  void FixedUpdate(){
        time += 0.2f;
    }
}
