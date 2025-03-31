using UnityEngine;

public class CheckOrder : MonoBehaviour
{
    public bool[] orders = new bool[11]; // 11 boolean array, all false by default
    public GameObject P6, tablet, wrongOrder;
    private int counter = 0;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finger"))
        {
            if (counter == 0)
            {
                CheckForChicken();
            }
            else if (counter == 1)
            {
                CheckForSteak();
            } else if (counter == 2)
            {
                CheckForPizza();
            }
        }
    }

    public void CheckForChicken()
    {
        bool correctIndexes = orders[4] && orders[5] && orders[7] && orders[9];
        bool otherIndexesFalse = true;
        
        // Check that all other indices (except 4, 5, 7, 9) are false
        for (int i = 0; i < orders.Length; i++)
        {
            if (i != 4 && i != 5 && i != 7 && i != 9 && orders[i])
            {
                otherIndexesFalse = false;
                break;
            }
        }

        if (correctIndexes && otherIndexesFalse)
        {
            counter++;
            Debug.Log("Counter: " + counter);
            Debug.Log("Chicken");
            P6.SetActive(true);
            tablet.SetActive(false);
        }
        else
        {
            Debug.Log("Not Chicken");
            wrongOrder.SetActive(true);
        }
    }

    public void CheckForSteak()
    {
        bool correctIndexes = orders[0] && orders[3] && orders[6] && orders[8];
        bool otherIndexesFalse = true;

        
        for (int i = 0; i < orders.Length; i++)
        {
            if (i != 0 && i != 3 && i != 6 && i != 8 && orders[i])
            {
                otherIndexesFalse = false;
                break;
            }
        }

        if (correctIndexes && otherIndexesFalse)
        {
            counter++;
            Debug.Log("Counter: " + counter);
            Debug.Log("Steak");
            P6.SetActive(true);
            tablet.SetActive(false);
        }
        else
        {
            Debug.Log("Not Steak");
            wrongOrder.SetActive(true);
        }
    }

    public void CheckForPizza()
    {
        bool correctIndexes = orders[1] && orders[4] && orders[8];
        bool otherIndexesFalse = true;

        
        for (int i = 0; i < orders.Length; i++)
        {
            if (i != 1 && i != 4 && i != 8 && orders[i])
            {
                otherIndexesFalse = false;
                break;
            }
        }

        if (correctIndexes && otherIndexesFalse)
        {
            counter++;
            Debug.Log("Counter: " + counter);
            Debug.Log("Pizza");
            P6.SetActive(true);
            tablet.SetActive(false);
        }
        else
        {
            Debug.Log("Not Pizza");
            wrongOrder.SetActive(true);
        }
    }
}
