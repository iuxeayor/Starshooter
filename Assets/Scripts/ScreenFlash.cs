using UnityEngine;
using System.Collections;

public class ScreenFlash : MonoBehaviour
{
	public GameObject FlashColor;
	public float start;
	public float end;
	public float duration;


	//under construction
	/*void Flash()
	{
		if (FlashColor.guiTexture.color.a == start)
		{
			for (float i = 0; i < 1.0; i += Time.deltaTime*(1/length)) 
			{ //for the length of time 
				currentObject.guiTexture.color.a = Mathf.Lerp(start, end, i); //lerp the value of the transparency from the start value to the end value in equal increments 
				yield; currentObject.guiTexture.color.a = end; // ensure the fade is completely finished (because lerp doesn't always end on an exact value) 
			} //end for
				
		} //end if
		
		//function FlashWhenHit (){ Fade (0, 0.8, 0.5, GUITextureobjectname); yield WaitForSeconds (.01); Fade (0.8, 0, 0.5, GUITextureobjectname); }
	}*/
}
