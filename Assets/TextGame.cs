using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextGame : MonoBehaviour
{
    [Header("Elements")]
    public Text titleText;
    public Text contentText;

    [Header("Config title text")]
    [TextArea]public string TitleText;
    [Header("Steps")]
    public Step activeStep;
    
    void Start()
    {
        titleText.text = TitleText;
        contentText.text = activeStep.GameText;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            CheckPress(0);
            Debug.Log("Input 1");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            CheckPress(1);
            Debug.Log("Input 2");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            CheckPress(2);
            Debug.Log("Input 3");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
        {
            CheckPress(3);
            Debug.Log("Input 4");
        }



    }

    void CheckPress(int index)
    {
        if (activeStep.nextSteps.Length > index)
        {
            if (activeStep != null)
            {
                activeStep = activeStep.nextSteps[index];
                contentText.text = activeStep.GameText;
            }
        }
    }
        

        

}
