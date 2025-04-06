using UnityEngine;

public class S2IconLogic : MonoBehaviour
{
    public GameObject Arrange1, Greet1, Guide1, Take1, Serve1;
    public GameObject Arrange2, Greet2, Guide2, Take2, Serve2;

    void Start()
    {
        // Set all icons to inactive at the beginning
        Arrange1.SetActive(false);
        Greet1.SetActive(false);
        Guide1.SetActive(false);
        Take1.SetActive(false);
        Serve1.SetActive(false);
        Arrange2.SetActive(false);
        Greet2.SetActive(false);
        Guide2.SetActive(false);
        Take2.SetActive(false);
        Serve2.SetActive(false);
    }

    // Public methods to activate individual icons
    public void ShowArrange1() => Arrange1.SetActive(true);
    public void ShowGreet1() => Greet1.SetActive(true);
    public void ShowGuide1() => Guide1.SetActive(true);
    public void ShowTake1() => Take1.SetActive(true);
    public void ShowServe1() => Serve1.SetActive(true);

    public void ShowArrange2() => Arrange2.SetActive(true);
    public void ShowGreet2() => Greet2.SetActive(true);
    public void ShowGuide2() => Guide2.SetActive(true);
    public void ShowTake2() => Take2.SetActive(true);
    public void ShowServe2() => Serve2.SetActive(true);
}
