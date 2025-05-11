using UnityEngine;

public class CheckOrder : MonoBehaviour
{
    public bool[] orders = new bool[11]; // 11 boolean array, all false by default
    public GameObject P6, tablet, wrongOrder;
    public GameObject P12, wrongOrder2;  
    private int counter = 0;
    public S2IconLogic icon;
    public TotalPoints points;
    public TotalProgress progress;
    public MenuOrder steak, pizza, pancake, salad, pasta, chicken, cake, coffee, coke, water, meal;
    public AudioSource correct;

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
                CheckForPizza();
            } else if (counter == 2)
            {
                CheckForSalad();
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
            icon.ShowTake1();
            correct.Play();
            P6.SetActive(true);
            tablet.SetActive(false);
            ResetOrders();
            steak.ResetVisuals();
            pizza.ResetVisuals();
            salad.ResetVisuals();
            pasta.ResetVisuals();
            chicken.ResetVisuals();
            cake.ResetVisuals();
            coffee.ResetVisuals();
            coke.ResetVisuals();
            water.ResetVisuals();
            meal.ResetVisuals();
            pancake.ResetVisuals();
            points.IncrementPoints(10);
            progress.IncrementProgress(8.33f);
        }
        else
        {
            Debug.Log("Not Chicken");
            points.DecrementPoints(2);
            wrongOrder.SetActive(true);
        }
    }

    

    public void CheckForPizza()
    {
        bool correctIndexes = orders[1] && orders[2] && orders[8];
        bool otherIndexesFalse = true;

        
        for (int i = 0; i < orders.Length; i++)
        {
            if (i != 1 && i != 2 && i != 8 && orders[i])
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
            icon.ShowTake2();
            correct.Play();
            points.IncrementPoints(10);
            P12.SetActive(true);
            tablet.SetActive(false);
        }
        else
        {
            Debug.Log("Not Pizza");
            points.DecrementPoints(2);
            wrongOrder2.SetActive(true);
        }
    }

    public void CheckForSalad()
    {
        bool correctIndexes = orders[4] && orders[3] && orders[6];
        bool otherIndexesFalse = true;


        for (int i = 0; i < orders.Length; i++)
        {
            if (i != 4 && i != 3 && i != 6 && orders[i])
            {
                otherIndexesFalse = false;
                break;
            }
        }

        if (correctIndexes && otherIndexesFalse)
        {
            counter++;
            Debug.Log("Counter: " + counter);
            Debug.Log("Salad");
            P6.SetActive(true);
            tablet.SetActive(false);
        }
        else
        {
            Debug.Log("Not Salad");
            wrongOrder.SetActive(true);
        }
    }

    public void ResetOrders()
    {
        for (int i = 0; i < orders.Length; i++)
        {
            orders[i] = false;
        }
    }

}
