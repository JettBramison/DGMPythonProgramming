using UnityEngine;
using System.Collections;

public class ConversationScript : MonoBehaviour 
{
	public int goldPieces = 5;
	public enum Emotion{Happy, Angry, Sad, Confused};
	
	void oldenDaysCircus()
	{

		Emotion myEmotion;
		
		myEmotion = Emotion.Happy;

		switch (goldPieces)
		{
		case 5:
			print ("You may enter the King's throne! AND you may take a picture with Ted the Dolphin.");
			goldPieces = -5;
			break;
		case 4:
			print ("Congratulations! You have enough gold to dress up like betty crocker!");
			goldPieces = -4;
			myEmotion = Emotion.Confused;
			break;
		case 3:
			print ("Whadya want?");
			goldPieces = -3;
			myEmotion = Emotion.Sad;
			break;
		case 2:
			print ("Well.... you can have a bagel...");
			goldPieces = -2;
			myEmotion = Emotion.Happy;
			break;
		case 1:
			print ("Wow... You know what? Why don't you go ahead and take some of mine? You probably need it more than I do.");
			goldPieces = +1500000000;
			break;
		case 0:
			print ("I'm sorry. You don't have enough to do anything. Why don't you go play in the dirt?");
			myEmotion = Emotion.Sad;
			break;
		default:
			print ("You are very very poor. Have you been drinking? Incorrect goldPieces");
			break;
		}
	}
}