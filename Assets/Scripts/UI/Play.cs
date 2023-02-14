using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {
    [Header("levels to load")]
    public string _newGameLvl;
    private string level2load;
    [SerializeField] private GameObject noSavedGameDialog = null;

    public void NewGameYes()
    {
         SceneManager.LoadScene(_newGameLvl);  
    }

    // Start is called before the first frame update
     public void LoadGameYes()
    {
       
        if (PlayerPrefs.HasKey("Savedlevel"))
        {
            level2load = PlayerPrefs.GetString("Savedlevel");
            SceneManager.LoadScene(level2load);  
        }
        else
        {
            
            GameObject.Find("loadgamedialog").SetActive(false);
            noSavedGameDialog.SetActive(true);
        }
    }


    public void Exit()
    {
        Application.Quit(); 
    }

}


