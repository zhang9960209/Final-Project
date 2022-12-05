using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Item Accumulator
public class ItemCollector : MonoBehaviour
{
    int coins = 0;

    [SerializeField] Text coinsText;

    [SerializeField] AudioSource collectionSound;

    private void OnTriggerEnter(Collider other) //colide with coin
    {
        if (other.gameObject.CompareTag("Coin")) //Compare the object tag
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "Coins: " + coins;
            collectionSound.Play();
        }
    }
}
