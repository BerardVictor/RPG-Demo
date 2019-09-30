using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingScene : MonoBehaviour
{
	public int playerrace = 0;
	public int playerclass = 0;
    bool racechoice = true;
    bool classchoice = false;

    public int p_Race;
    public int p_Class;
    public int speed;
    public int health;
    public int strengh;
    public int dexterity;
    public int vitality;
    public int intelligence;
    public int wisdom;
    public int charisma;

    bool RandomStats = false;

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
                playerrace = 1;
                PlayerPrefs.SetInt("PlayerRace", playerrace);
                racechoice = false;
                classchoice = true;
            }
        
            // Make the second button.
            if(GUI.Button(new Rect(810,520,300,80), "Elven")) 
            {
                playerrace = 2;
                PlayerPrefs.SetInt("PlayerRace", playerrace);
                racechoice = false;
                classchoice = true;
            }

            if(GUI.Button(new Rect(810,610,300,80), "Human")) 
            {
                playerrace = 3;
                PlayerPrefs.SetInt("PlayerRace", playerrace);
                racechoice = false;
                classchoice = true;
            }
        }

        if (classchoice)
        {
            GUI.Box(new Rect(800,345,320,390), "Choose your Class");
            if(GUI.Button(new Rect(810,375,300,80), "Warrior"))
            {
            	playerclass = 1;
                PlayerPrefs.SetInt("PlayerClass", playerclass);
                classchoice = false;
                RandomStats = true;
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

        	if(GUI.Button(new Rect(810,465,300,80), "Priest"))
           	{
           		playerclass = 2;
                PlayerPrefs.SetInt("PlayerClass", playerclass);
                classchoice = false;
                RandomStats = true;
           	}

        	if(GUI.Button(new Rect(810,555,300,80), "Magician"))
           	{
           		playerclass = 3;
                PlayerPrefs.SetInt("PlayerClass", playerclass);
                classchoice = false;
                RandomStats = true;
           	}

           	if(GUI.Button(new Rect(810,645,300,80), "Assassin"))
           	{
           		playerclass = 4;
                PlayerPrefs.SetInt("PlayerClass", playerclass);
                classchoice = false;
                RandomStats = true;
           	}
        }

        if (RandomStats)
        {
            if(GUI.Button(new Rect(660,430,600,80), "Clic to randomly generate your character statistics"))
            {
                strengh = Random.Range(3,19);
                dexterity = Random.Range(3,19);
                vitality = Random.Range(3,19);
                intelligence = Random.Range(3,19);
                wisdom = Random.Range(3,19);
                charisma = Random.Range(3,19);

                if (playerrace == 1)
                {
                    speed = 4;
                    vitality += 2;
                    wisdom += 2;
                    charisma -= 2;
                }

                if (playerrace == 2)
                {
                    speed = 6;
                    dexterity += 2;
                    intelligence += 2;
                    vitality -= 2;
                }

                if (playerrace == 3)
                {
                    speed = 5;
                }

                if (playerclass == 1)
                {
                    health = 10;
                    strengh += 2;
                    vitality += 1;
                    dexterity += 1;
                }

                if (playerclass == 2)
                {
                    health = 8;
                    wisdom += 2;
                    vitality += 1;
                    charisma += 1;
                }

                if (playerclass == 3)
                {
                    health = 6;
                    intelligence += 2;
                    vitality += 1;
                    dexterity += 1;
                }

                if (playerclass == 4)
                {
                    health = 8;
                    dexterity += 2;
                    vitality += 1;
                    strengh += 1;
                }
            }

            GUI.Box(new Rect(860,550,200,100), "strengh is " + strengh + "\ndexterity is " + dexterity + "\nvitality is " + vitality + "\nintelligence is " + intelligence + "\nwisdom is " + wisdom + "\ncharisma is " + charisma);

            if(GUI.Button(new Rect(885,660,150,80), "Next step"))
            {
                RandomStats = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }


    void Update ()
    {

    }
}
