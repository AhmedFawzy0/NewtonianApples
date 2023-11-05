using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class collisionDetect : MonoBehaviour
{
    public TextMeshProUGUI collisionCount;
    public static int counter = -1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.name == "SquareLeft")
        {
            counter++;
            collisionCount.text = "Collision #: " + counter;
        }

        else if(collision.gameObject.name == "rightColoum")
        {

            counter++;
            collisionCount.text = "Collision #: " + counter;

        }
    }
}
