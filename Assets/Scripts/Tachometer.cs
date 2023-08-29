using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tachometer : MonoBehaviour
{
    public float minRPM;
    public float maxRPM;
    public AudioSource engine;
    public RectTransform needle;
    float RPM;
    int currentGear;

    public Text speed;
    public Text speed1;
    public Text speed2;
    public Text speed3;
    public Text speed4;

    public Text gear;
    public Text gear1;
    public Text gear2;
    public Text gear3;
    public Text gear4;

    float carSpeed;

    public Rigidbody rb;

    public CarController car;

    // Update is called once per frame
    void Update()
    {
        RPM = engine.pitch;

        if (needle != null)
            needle.localEulerAngles =
                new Vector3(0, 0, Mathf.Lerp(minRPM, maxRPM, RPM / 100));

        currentGear = car.currentGearIndex;
        carSpeed = rb.velocity.magnitude;

        speed.text = carSpeed.ToString("0 KPH");
        speed1.text = carSpeed.ToString("0 KPH");
        speed2.text = carSpeed.ToString("0 KPH");
        speed3.text = carSpeed.ToString("0 KPH");
        speed4.text = carSpeed.ToString("0 KPH");

        gear.text = currentGear.ToString("");
        gear1.text = currentGear.ToString("");
        gear2.text = currentGear.ToString("");
        gear3.text = currentGear.ToString("");
        gear4.text = currentGear.ToString("");

        if (gear != null)
            gear.text = ((int)currentGear) + "";

        if (gear1 != null)
            gear1.text = ((int)currentGear) + "";

        if (gear2 != null)
            gear2.text = ((int)currentGear) + "";
        
        if (gear3 != null)
            gear3.text = ((int)currentGear) + "";

        if (gear4 != null)
            gear4.text = ((int)currentGear) + "";

        if (car.forward == true)
        {
            if (currentGear == 0)
            {
                gear.text = ((int)currentGear).ToString();
                gear.text = "1";

                gear1.text = ((int)currentGear).ToString();
                gear1.text = "1";

                gear2.text = ((int)currentGear).ToString();
                gear2.text = "1";

                gear3.text = ((int)currentGear).ToString();
                gear3.text = "1";

                gear4.text = ((int)currentGear).ToString();
                gear4.text = "1";
            }

            if (currentGear == 1)
            {
                gear.text = ((int)currentGear).ToString();
                gear.text = "2";

                gear1.text = ((int)currentGear).ToString();
                gear1.text = "2";

                gear2.text = ((int)currentGear).ToString();
                gear2.text = "2";

                gear3.text = ((int)currentGear).ToString();
                gear3.text = "2";

                gear4.text = ((int)currentGear).ToString();
                gear4.text = "2";
            }

            if (currentGear == 2)
            {
                gear.text = ((int)currentGear).ToString();
                gear.text = "3";

                gear1.text = ((int)currentGear).ToString();
                gear1.text = "3";

                gear2.text = ((int)currentGear).ToString();
                gear2.text = "3";

                gear3.text = ((int)currentGear).ToString();
                gear3.text = "3";

                gear4.text = ((int)currentGear).ToString();
                gear4.text = "3";
            }

            if (currentGear == 3)
            {
                gear.text = ((int)currentGear).ToString();
                gear.text = "4";

                gear1.text = ((int)currentGear).ToString();
                gear1.text = "4";

                gear2.text = ((int)currentGear).ToString();
                gear2.text = "4";

                gear3.text = ((int)currentGear).ToString();
                gear3.text = "4";

                gear4.text = ((int)currentGear).ToString();
                gear4.text = "4";
            }

            if (currentGear == 4)
            {
                gear.text = ((int)currentGear).ToString();
                gear.text = "5";

                gear1.text = ((int)currentGear).ToString();
                gear1.text = "5";

                gear2.text = ((int)currentGear).ToString();
                gear2.text = "5";

                gear3.text = ((int)currentGear).ToString();
                gear3.text = "5";

                gear4.text = ((int)currentGear).ToString();
                gear4.text = "5";
            }

            if (currentGear == 5)
            {
                gear.text = ((int)currentGear).ToString();
                gear.text = "6";

                gear1.text = ((int)currentGear).ToString();
                gear1.text = "6";

                gear2.text = ((int)currentGear).ToString();
                gear2.text = "6";

                gear3.text = ((int)currentGear).ToString();
                gear3.text = "6";

                gear4.text = ((int)currentGear).ToString();
                gear4.text = "6";
            }
        }
        else
        {
            if (currentGear == 0)
            {
                gear.text = ((int)currentGear).ToString();
                gear.text = "R";

                gear1.text = ((int)currentGear).ToString();
                gear1.text = "R";

                gear2.text = ((int)currentGear).ToString();
                gear2.text = "R";

                gear3.text = ((int)currentGear).ToString();
                gear3.text = "R";

                gear4.text = ((int)currentGear).ToString();
                gear4.text = "R";
            }


            if (currentGear == 1)
            {
                gear.text = ((int)currentGear).ToString();
                gear.text = "R";

                gear1.text = ((int)currentGear).ToString();
                gear1.text = "R";

                gear2.text = ((int)currentGear).ToString();
                gear2.text = "R";

                gear3.text = ((int)currentGear).ToString();
                gear3.text = "R";

                gear4.text = ((int)currentGear).ToString();
                gear4.text = "R";
            }

            if (currentGear == 2)
            {
                gear.text = ((int)currentGear).ToString();
                gear.text = "R";

                gear1.text = ((int)currentGear).ToString();
                gear1.text = "R";

                gear2.text = ((int)currentGear).ToString();
                gear2.text = "R";

                gear3.text = ((int)currentGear).ToString();
                gear3.text = "R";

                gear4.text = ((int)currentGear).ToString();
                gear4.text = "R";
            }

            if (currentGear == 3)
            {
                gear.text = ((int)currentGear).ToString();
                gear.text = "R";

                gear1.text = ((int)currentGear).ToString();
                gear1.text = "R";

                gear2.text = ((int)currentGear).ToString();
                gear2.text = "R";

                gear3.text = ((int)currentGear).ToString();
                gear3.text = "R";

                gear4.text = ((int)currentGear).ToString();
                gear4.text = "R";
            }

            if (currentGear == 4)
            {
                gear.text = ((int)currentGear).ToString();
                gear.text = "R";

                gear1.text = ((int)currentGear).ToString();
                gear1.text = "R";

                gear2.text = ((int)currentGear).ToString();
                gear2.text = "R";

                gear3.text = ((int)currentGear).ToString();
                gear3.text = "R";

                gear4.text = ((int)currentGear).ToString();
                gear4.text = "R";
            }

            if (currentGear == 5)
            {
                gear.text = ((int)currentGear).ToString();
                gear.text = "R";

                gear1.text = ((int)currentGear).ToString();
                gear1.text = "R";

                gear2.text = ((int)currentGear).ToString();
                gear2.text = "R";

                gear3.text = ((int)currentGear).ToString();
                gear3.text = "R";

                gear4.text = ((int)currentGear).ToString();
                gear4.text = "R";
            }
        }
        
    }
}
