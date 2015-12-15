using UnityEngine;
using System.Collections;

public class Enumerationt : MonoBehaviour 
{
	public enum Emotion{Happy, Angry, Sad, Confused};

	void Start () 
	{
		Emotion myEmotion;
		
		myEmotion = Emotion.Happy;
	}
	
	Emotion OppositeEmotion (Emotion emo)
	{
		if(emo == Emotion.Happy)
			emo = Emotion.Sad;
		else if(emo == Emotion.Sad)
			emo = Emotion.Happy;
		else if(emo == Emotion.Angry)
			emo = Emotion.Confused;
		else if(emo == Emotion.Confused)
			emo = Emotion.Angry;
		
		return emo;     
	}
}