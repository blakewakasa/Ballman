using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	void OnTriggerEnter (Collider other){
        SizeChange.isSmall = false;
        SizeChange.isRegular = true;
        SizeChange.isBig = false;
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex+1);
	}
}
