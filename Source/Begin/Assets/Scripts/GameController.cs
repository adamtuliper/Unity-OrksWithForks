using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Image HealthBar;
    public Text CoinText;


    public void UpdatePlayerHealth(int health)
    {
        HealthBar.fillAmount = health / 100f;
        if (health < 50)
        {
            HealthBar.color = Color.red;
        }
    }

    public void UpdatePlayerCoin(int coinScore)
    {
        CoinText.text = coinScore.ToString();
    }
}
