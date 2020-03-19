using UnityEngine;
using UnityEngine.UI;

public class TextGame : MonoBehaviour
{
    [Header("Elements")]
    public Text placeText;
    public Text episodeText;
    public Text contentText;
    public Image backGround;

    [Header("Steps")]
    public Data activeStep;

    void Start()
    {
        placeText.text = activeStep.placeText;
        episodeText.text = activeStep.episodeText;
        contentText.text = activeStep.contentText;
        backGround.sprite = activeStep.backGround;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            CheckPress(0);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            CheckPress(1);
        }
    }

    void CheckPress(int index)
    {
        if (activeStep.nextSteps.Length > index)
        {
            if (activeStep != null)
            {
                activeStep = activeStep.nextSteps[index];
                placeText.text = activeStep.placeText;
                contentText.text = activeStep.contentText;
                backGround.sprite = activeStep.backGround;
            }
        }
    }
}
