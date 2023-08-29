using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class TimeAttack : MonoBehaviour
{
    public Text timerText;
    public Text timerText2;
    public Text timerText3;
    public Text timerText4;
    public Text timerText5;
    public GameObject car;
    public GameObject redlight;
    public GameObject redlight2;
    public GameObject redlight3;
    public GameObject greenlight;

    public CarController carControl;

    private bool countdownFinished = false;
    private bool raceStarted = false;
    private bool raceFinished = false;
    private float elapsedTime = 0f;

    void Start()
    {
        car.GetComponent<Rigidbody>().isKinematic = true; // Disable car movement initially
        StartCoroutine(StartCountdown());
    }

    void Update()
    {
        if (raceStarted && !raceFinished)
        {
            if (countdownFinished)
            {
                elapsedTime += Time.deltaTime;
                DisplayTime(elapsedTime);
            }
        }
    }

    IEnumerator StartCountdown()
    {
        redlight.SetActive(true);
        yield return new WaitForSeconds(1f);
        redlight2.SetActive(true);
        yield return new WaitForSeconds(1f);
        redlight3.SetActive(true);
        yield return new WaitForSeconds(1f);
        greenlight.SetActive(true);
        redlight.SetActive(false);
        redlight2.SetActive(false);
        redlight3.SetActive(false);
        countdownFinished = true;
        car.GetComponent<Rigidbody>().isKinematic = false; // Enable car movement
        raceStarted = true;
        yield return new WaitForSeconds(1f);
        greenlight.SetActive(false);
    }

    void DisplayTime(float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        float milliseconds = (time % 1) * 100;
        timerText.text = string.Format("{0:00}:{1:00}.{2:00}", minutes, seconds, milliseconds);
        timerText2.text = string.Format("{0:00}:{1:00}.{2:00}", minutes, seconds, milliseconds);
        timerText3.text = string.Format("{0:00}:{1:00}.{2:00}", minutes, seconds, milliseconds);
        timerText4.text = string.Format("{0:00}:{1:00}.{2:00}", minutes, seconds, milliseconds);
        timerText5.text = string.Format("{0:00}:{1:00}.{2:00}", minutes, seconds, milliseconds);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FinishTrigger"))
        {
            carControl.handBrakeOn = true;
            raceFinished = true;
            raceStarted = false;
        }
    }

}