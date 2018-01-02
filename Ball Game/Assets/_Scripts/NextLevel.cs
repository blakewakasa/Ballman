using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	void OnTriggerEnter (Collider other){
        SizeChange.ResetAll();
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex+1);
	}
}
