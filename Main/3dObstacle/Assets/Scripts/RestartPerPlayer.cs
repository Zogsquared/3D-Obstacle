using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartPerPlayer : MonoBehaviour
{
    [SerializeField]
    string strTag;
    public Vector3 playerPos;
    private Vector3 spawn;

    [SerializeField]
    private Vector3 v3Force;
    //Quaternion target = Quaternion.Euler(0, 0, 0);


  private void Start() {
    Vector3 spawn = transform.position;
    Debug.Log(spawn);
  }

  private void OnCollisionEnter(Collision collision) {
      if (collision.collider.tag == strTag) {
            Debug.Log(transform.position = transform.position + spawn);
           transform.position = playerPos; 
           GetComponent<Rigidbody>().velocity = v3Force;
           //transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime);
      }
  }
}


//new Vector3(-1.21f, 4.56f, 0.87f)