using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour 
{
	float explosivePressure = 1.0f;
	float upperLimitPressure = 60.0f;
	float lowerLimitPressure = 30.0f;


	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space))
			TemperatureTest ();

		explosivePressure += Time.deltaTime * 5f;
	}

	void TemperatureTest ()
	{
		//if the explosive's pressure is greater than the lowest limit
		if (explosivePressure < lowerLimitPressure) {
			//do this
			print ("Pressure Levels are reaching ciritcal. Evacuation is advised.");

		}

		// if the pressure is greater than the upper most pressure limit
		else if (explosivePressure > upperLimitPressure) {
			//do this
			print ("Pressure Levels Critical: Immediate evactuation required!");
		}

		// If it's neiter of those then
		else {
			print ("Pressure levels are stable however, the levels are rising.");
		}
	}

}
