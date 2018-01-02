
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class LoadLevel : MonoBehaviour {
    public TextMeshProUGUI mText;
    
    public void ChooseLevel()
    {
        SceneManager.LoadScene(int.Parse(mText.text));
    }

}
