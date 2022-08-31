
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class levelhandler: MonoBehaviour
{
    public void level1()
    {
         
     SceneManager.LoadScene("level 1");

    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit(); 
    }
        
    }

