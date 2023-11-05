using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public InputField[] inputFields;
    public float[] variables;

    // Start is called before the first frame update
    void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);

    }

    public void CollectData()
    {
        inputFields[0] = GameObject.Find("Mass 1").GetComponent<InputField>();
        inputFields[1] = GameObject.Find("Mass 2").GetComponent<InputField>();
        inputFields[2] = GameObject.Find("Velocity 1").GetComponent<InputField>();
        inputFields[3] = GameObject.Find("Velocity 2").GetComponent<InputField>();

        int i = 0;
        foreach(InputField input in inputFields)
        {
            variables[i] = float.Parse(input.text);
            i++;
        }
    }
}
