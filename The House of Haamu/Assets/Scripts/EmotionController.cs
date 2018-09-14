using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class EmotionController : NetworkBehaviour
{
    public int CurrentGhostEmotionalValue;
    public int LowestEmotionalValue = -400;

    private int PreviousEmotionalValue;
	
	// Update is called once per frame
	void Update ()
    {
        // this checks to see if the players cause the ghosts emotional value
        if (CurrentGhostEmotionalValue < LowestEmotionalValue)
        {
            CurrentGhostEmotionalValue = LowestEmotionalValue;
        }

		if (CurrentGhostEmotionalValue != PreviousEmotionalValue)
        {
            if (CurrentGhostEmotionalValue >= 200)
            {
                PreviousEmotionalValue = CurrentGhostEmotionalValue;
            }
            else if (CurrentGhostEmotionalValue < 200 && CurrentGhostEmotionalValue >= 100)
            {
                PreviousEmotionalValue = CurrentGhostEmotionalValue;
            }
            else if (CurrentGhostEmotionalValue < 100 && CurrentGhostEmotionalValue >= 50)
            {
                PreviousEmotionalValue = CurrentGhostEmotionalValue;
            }
            else if (CurrentGhostEmotionalValue < 50 && CurrentGhostEmotionalValue >= -50)
            {
                PreviousEmotionalValue = CurrentGhostEmotionalValue;
            }
            else if (CurrentGhostEmotionalValue < -50 && CurrentGhostEmotionalValue >= -100)
            {
                PreviousEmotionalValue = CurrentGhostEmotionalValue;
            }
            else if (CurrentGhostEmotionalValue < -100 && CurrentGhostEmotionalValue >= -200)
            {
                PreviousEmotionalValue = CurrentGhostEmotionalValue;
            }
            else if (CurrentGhostEmotionalValue < -200 && CurrentGhostEmotionalValue >= LowestEmotionalValue)
            {
                PreviousEmotionalValue = CurrentGhostEmotionalValue;
            }
        }
	}
}
