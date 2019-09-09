using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewStarter : MonoBehaviour
{
	public int Race = 0;
	public int Class = 0;

    bool racechoice = true;
    bool classchoice = false;

    void OnGUI ()
    {
        if(GUI.Button(new Rect(1850, 10, 50, 30), "Quit"))
        {
            Application.Quit();
        }

        if (racechoice)
        {
            GUI.Box(new Rect(800,400,320,300), "Choose your Race");

            if(GUI.Button(new Rect(810,430,300,80), "Dwarf"))
            {
                Race = 1;
                racechoice = false;
                classchoice = true;
            }
        
            // Make the second button.
            if(GUI.Button(new Rect(810,520,300,80), "Elven")) 
            {
                Race = 2;
                racechoice = false;
                classchoice = true;
            }

            if(GUI.Button(new Rect(810,610,300,80), "Human")) 
            {
                Race = 3;
                racechoice = false;
                classchoice = true;
            }
        }

        if (classchoice)
        {
            GUI.Box(new Rect(800,345,320,390), "Choose your Class");
            if(GUI.Button(new Rect(810,375,300,80), "Warrior"))
            {
            	Class = 1;
                classchoice = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

        	if(GUI.Button(new Rect(810,465,300,80), "Priest"))
           	{
           		Class = 2;
                classchoice = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
           	}

        	if(GUI.Button(new Rect(810,555,300,80), "Magician"))
           	{
           		Class = 3;
                classchoice = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
           	}

           	if(GUI.Button(new Rect(810,645,300,80), "Assassin"))
           	{
           		Class = 4;
                classchoice = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
           	}
        }
    }

    void Update ()
    {
    	Debug.Log("Race is " + Race);
        Debug.Log("Class is " + Class);
    }
}
