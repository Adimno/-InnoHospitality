using UnityEngine;

public class S1IconLogic : MonoBehaviour
{
    public GameObject TrashIcon, BedIcon, TurnOffIcon, CleanIcon, BathIcon, CheckAllRoom, Tools;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        TrashIcon.SetActive(false);
        BedIcon.SetActive(false);
           TurnOffIcon.SetActive(false);
            CleanIcon.SetActive(false);
        BathIcon.SetActive(false);
        CheckAllRoom.SetActive(false);
   
    }

       public void ToolsIconLogic()
    {
        Tools.SetActive(true);
    }
        

    public void TrashIconLogic()
    {
        TrashIcon.SetActive(true);
    }

        public void BedIconLogic()
    {
        BedIcon.SetActive(true);
    }
     public void TurnOffIconLogic()
    {
        TurnOffIcon.SetActive(true);
    }

      public void CLeanIconLogic()
    {
        CleanIcon.SetActive(true);
    }

        public void BathIconLogic()
    {
        BathIcon.SetActive(true);
    }

        public void CheckAllRoomIconLogic()
    {
        CheckAllRoom.SetActive(true);
    }





}
