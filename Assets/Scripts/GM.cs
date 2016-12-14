using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public int points = 0;
    public int lives = 3;

    public Text scoreText;
    public Text livesText;

    public GameObject outSign;
    public GameObject winSign;

    void Start()
    {
        scoreText.text = points.ToString();
        livesText.text = lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Coinscollected(int worth)
    {
        points+= worth;
        scoreText.text = points.ToString();

        if (points == 25)
        {
            winSign.SetActive(true);
            Application.LoadLevel("level_2");
        }
    }

    public void LifeWasLost()
    {
        lives--;
        livesText.text = lives.ToString();

        if (lives == 0)
        {
            outSign.SetActive(true);
        }
    }
}
