using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class resetButton : MonoBehaviour
{
    public GameObject SquareLeft;
    public GameObject SquareRight;
    public Button button;
    public TextMeshProUGUI collisionButton;


    public void MoveBlocks()
    {

        Rigidbody2D SquareLeftRb = SquareLeft.GetComponent<Rigidbody2D>();
        Rigidbody2D SquareRightRb = SquareRight.GetComponent<Rigidbody2D>();

        SquareLeftRb.velocity = new Vector2(0, 0);
        SquareRightRb.velocity = new Vector2(0, 0);
        SquareLeft.transform.position = new Vector2(-7, -2f);
        SquareRight.transform.position = new Vector2(8, -2f);

        SquareLeftRb.velocity = new Vector2(DataManager.Instance.variables[2], 0);
        SquareRightRb.velocity = new Vector2(-1*DataManager.Instance.variables[3], 0);

        collisionDetect.counter = 0;

        collisionButton.text = "Collison #: 0";
    }

    public void PauseGame()
    {

        TextMeshProUGUI buttonText = button.GetComponentInChildren<TextMeshProUGUI>();
        string buttonStr = buttonText.text;

        if (buttonStr == "Pause")
        {
            Time.timeScale = 0;
            buttonText.text = "Resume";
        }

        else
        {
            Time.timeScale = 1; 
            buttonText.text = "Pause";
        }
    }


}

