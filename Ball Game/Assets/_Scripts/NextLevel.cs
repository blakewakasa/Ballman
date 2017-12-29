using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	void OnTriggerEnter (Collider other){
        ChangeSize.isBig = false;
        ChangeSize.isSmall = false;
        ChangeSize.isRegular = true;
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex+1);
	}
}
