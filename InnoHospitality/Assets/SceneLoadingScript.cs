using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class SceneLoadingScript : MonoBehaviour
{

    // This method is called when the button is clicked
    public void MoveToTutorial()
    {
        
            StartCoroutine(LoadScene("Tutorial"));
 
 

    }
    public void MoveToMain_Menu()
    {
        StartCoroutine(LoadScene("MainMenu"));
    }

    public void MoveToReception()
    {
        StartCoroutine(LoadScene("Reception_Scene"));
    }
    
    public void MoveToHouseKeeping()
    {
        StartCoroutine(LoadScene("HouseKeeping_Scene"));
    }

     public void MoveToTableService()
    {
        StartCoroutine(LoadScene("TableService_Scene"));
    }


    public void ExitGame()
    {
        Application.Quit();
    }

  IEnumerator LoadScene(string sceneName)
    {


        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        asyncLoad.allowSceneActivation = false; //scene will not load while this value is false

        // Allow the scene to be activated
        asyncLoad.allowSceneActivation = true;

        // Wait for the scene to finish loading
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

    }
}
