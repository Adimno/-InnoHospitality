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

      public void MoveToCutSceneS1()
    {
        StartCoroutine(LoadScene("CutSceneS1"));
    }

       public void MoveToCutSceneS2()
    {
        StartCoroutine(LoadScene("CutSceneS2"));
    }


    public void ExitGame()
    {
        Application.Quit();
    }

    public IEnumerator LoadScene(string sceneName)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);
        asyncLoad.allowSceneActivation = false;

        asyncLoad.allowSceneActivation = true;

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

}
