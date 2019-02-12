using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollideScript : MonoBehaviour
{
    public Text countText;
    public Text WinText;
    private int count;
   


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();

        }
    }


    void SetCountText()  
    {
        countText.text = "Count:" + count.ToString();

        if (count >= 3)
        {
            WinText.text = "You Win!";
        }

    }




}