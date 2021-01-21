using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAndWordCompletion : MonoBehaviour
{
    // public static Dictionary<int, string> currentWord = new Dictionary<int, string>();
    public static string[] englishWords = { "APPLE", "GRAPE", "PEAR", "RED", "GREEN", "BLUE", "DOOR", "WORDVENTURE", "GREAT", "BAD", "TIME", "SOAP"}; //lan = 1
    public static string[] spanishWords = { "MANZANA", "UVA", "PERA" }; //lan = 2
    public static string[] germanWords = { "APFEL", "TRAUBE", "BIRNE" };//lan = 3
    public static string[] frenchWords = { "POMME", "RAISIN", "POIRE" };//lan = 4
    public static string progress = " ";
    public static string currentWord;
    public static int wordIndex;
    public static int letterCount = 0;
    public static int currentWordLength;
    public static bool complete = false;
    public static int language = 1;
    public GameObject aPrefab;
    public GameObject bPrefab;
    public GameObject cPrefab;
    public GameObject dPrefab;
    public GameObject ePrefab;
    public GameObject fPrefab;
    public GameObject gPrefab;
    public GameObject hPrefab;
    public GameObject iPrefab;
    public GameObject jPrefab;
    public GameObject kPrefab;
    public GameObject lPrefab;
    public GameObject mPrefab;
    public GameObject nPrefab;
    public GameObject oPrefab;
    public GameObject pPrefab;
    public GameObject qPrefab;
    public GameObject rPrefab;
    public GameObject sPrefab;
    public GameObject tPrefab;
    public GameObject uPrefab;
    public GameObject vPrefab;
    public GameObject wPrefab;
    public GameObject xPrefab;
    public GameObject yPrefab;
    public GameObject zPrefab;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject spawn4;
    public GameObject spawn5;
    public GameObject spawn6;
    public GameObject spawn7;
    public GameObject spawn8;
    public GameObject spawn9;
    public GameObject spawn10;
    public GameObject spawn11;
    public GameObject spawn12;
    public GameObject spawn13;
    public GameObject spawn14;
    public GameObject spawn15;
    public GameObject spawn16;
    public GameObject spawn17;
    public GameObject spawn18;
    public GameObject spawn19;
    public Text wordToComplete;
    public Text wordCompletion;

    public List<GameObject> spawns = new List<GameObject>();
    //Choose a word from a library of words
    void Start()
    {
        //Instantiate(Prefab, new Vector3(x, y, z), Quaternion.identity);
        chooseWord();
        wordToComplete.text = englishWords[wordIndex];
        wordCompletion.text = " ";
        createLetters(currentWord);
        Cursor.visible = false;
        Screen.lockCursor = true;
    }

    void Update()
    {
        wordCompletion.text = progress;
    }


    public static void chooseWord()
    {
        wordIndex = Random.Range(0, englishWords.Length);
        if (language == 1)
        {
            currentWord = englishWords[wordIndex];
        }

        else if (language == 2)
        {
            currentWord = spanishWords[wordIndex];
        }

        else if (language == 3)
        {
            currentWord = germanWords[wordIndex];
        }

        else if (language == 4)
        {
            currentWord = frenchWords[wordIndex];
        }
    }

    //-2 - 2, -1 - 17
    void createLetters(string word)
    {
        spawns.Add(spawn1);
        spawns.Add(spawn2);
        spawns.Add(spawn3);
        spawns.Add(spawn4);
        spawns.Add(spawn5);
        spawns.Add(spawn6);
        spawns.Add(spawn7);
        spawns.Add(spawn8);
        spawns.Add(spawn9);
        spawns.Add(spawn10);
        spawns.Add(spawn11);
        spawns.Add(spawn12);
        spawns.Add(spawn13);
        spawns.Add(spawn14);
        spawns.Add(spawn15);
        spawns.Add(spawn16);
        spawns.Add(spawn17);
        spawns.Add(spawn18);
        spawns.Add(spawn19);
        currentWordLength = word.Length;
        Vector3 position = new Vector3();
        int index;
        Quaternion rotation;
        for (int i = 0; i < word.Length; i++)
        {
            index = Random.Range(0, spawns.Count);
            position = spawns[index].transform.position;
            rotation = spawns[index].transform.rotation;
            spawns.RemoveAt(index);
            float x = position.x;
            float y = position.y;
            float z = position.z;
            if (word[i] == 'A')
            {
                var obj = Instantiate(aPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'A';
            }

            else if (word[i] == 'B')
            {
                var obj = Instantiate(bPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'B';
            }

            else if (word[i] == 'C')
            {
                var obj = Instantiate(cPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'C';
            }

            else if (word[i] == 'D')
            {
                var obj = Instantiate(dPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'D';
            }

            else if (word[i] == 'E')
            {
                var obj = Instantiate(ePrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'E';
            }

            else if (word[i] == 'F')
            {
                var obj = Instantiate(fPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'F';
            }

            else if (word[i] == 'G')
            {
                var obj = Instantiate(gPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'G';
            }

            else if (word[i] == 'H')
            {
                var obj = Instantiate(hPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'H';
            }

            else if (word[i] == 'I')
            {
                var obj = Instantiate(iPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'I';
            }

            else if (word[i] == 'J')
            {
                var obj = Instantiate(jPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'J';
            }

            else if (word[i] == 'K')
            {
                var obj = Instantiate(kPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'K';
            }

            else if (word[i] == 'L')
            {
                var obj = Instantiate(lPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'L';
            }

            else if (word[i] == 'M')
            {
                var obj = Instantiate(mPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'M';
            }

            else if (word[i] == 'N')
            {
                var obj = Instantiate(nPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'N';
            }

            else if (word[i] == 'O')
            {
                var obj = Instantiate(oPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'O';
            }

            else if (word[i] == 'P')
            {
                var obj = Instantiate(pPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'P';
            }

            else if (word[i] == 'Q')
            {
                var obj = Instantiate(qPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'Q';
            }

            else if (word[i] == 'R')
            {
                var obj = Instantiate(rPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'R';
            }

            else if (word[i] == 'S')
            {
                var obj = Instantiate(sPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'S';
            }

            else if (word[i] == 'T')
            {
                var obj = Instantiate(tPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'T';
            }

            else if (word[i] == 'U')
            {
                var obj = Instantiate(uPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'U';
            }

            else if (word[i] == 'V')
            {
                var obj = Instantiate(vPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'V';
            }

            else if (word[i] == 'W')
            {
                var obj = Instantiate(wPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'W';
            }

            else if (word[i] == 'X')
            {
                var obj = Instantiate(xPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'X';
            }

            else if (word[i] == 'Y')
            {
                var obj = Instantiate(yPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'Y';
            }

            else if (word[i] == 'Z')
            {
                var obj = Instantiate(zPrefab, new Vector3(x, y, z), rotation);
                obj.GetComponent<CollectableLetter>().letter = 'Z';
            }
        }
    }
    //Called by a letter object, updates word, letterCount, and complete. Return true if letter matches word, return false otherwise

    public static bool checkLetter(char letter)
    {
        if (currentWord[letterCount] == letter)
        {
            progress = progress + letter;
            letterCount++;
            if (letterCount == currentWordLength)
            {
                complete = true;
            }
            return true;
        }
        return false;
    }
}
