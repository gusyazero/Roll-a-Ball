using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class DangerWall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            //Application.LoadLevel(Application.loadedLevel);
            //SceneManager.LoadScene("stage01");
            SceneManager.LoadScene(Application.loadedLevel);
        }
    }
}
