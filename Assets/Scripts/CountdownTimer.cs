using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

public class CountdownTimer : MonoBehaviour
{
    public float initialTime = 60.0f; // Starting time in seconds
    public float addedTime;
    private float currentTime;

    public CarController carControl;
    public TimeAttack ta;

    public Text timerText;
    public Text timerText2;
    public Text timerText3;
    public Text timerText4;
    public Text timerText5;

    private void Start()
    {
        currentTime = initialTime;
    }

    private void Update()
    {
        if (ta.raceStarted)
        {
            if (currentTime > 0)
            {
                currentTime -= Time.deltaTime;
                UpdateTimerDisplay();
            }
            else
            {
                carControl.handBrakeOn = true;
                currentTime = 0; // Ensure the timer stays at 0
                UpdateTimerDisplay();
            }
        }
    }

    private void UpdateTimerDisplay()
    {
        int seconds = Mathf.FloorToInt(currentTime % 60);
        string timerString = string.Format("{00}", seconds);
        timerText.text = timerString;
        timerText2.text = timerString;
        timerText3.text = timerString;
        timerText4.text = timerString;
        timerText5.text = timerString;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            currentTime += addedTime;
            UpdateTimerDisplay();
            carControl.handBrakeOn = false;
            Destroy(other.gameObject);
        }
    }
}
