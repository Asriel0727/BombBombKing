using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateFire : MonoBehaviour
{
    public PlayerAttribute sleepBaby = new SleepBaby();

    public PlayerAttribute blueBaby = new BlueBaby();

    public Canvas canvas;

    public GameObject fire;

    private Image image;

    public IEnumerator PlayerCreateFire(Collider2D collision, GameObject player)
    {
        yield return new WaitForSeconds(1.7f);
        float x = collision.transform.position.x;
        float y = collision.transform.position.y;

        if (player.tag == "Player1")
        {
            int j;
            j = sleepBaby.bombRange;
            for (int i = 1; i <= 1; i++)
            {
                GameObject firePrefab = Instantiate(fire, new Vector3(Mathf.RoundToInt(x), Mathf.RoundToInt(y), 0), fire.transform.rotation);
                firePrefab.transform.SetParent(canvas.transform, false);
            }
            StartCoroutine(SideFire(x, y, j));
        }
        else
        {
            int j;
            j = blueBaby.bombRange;
            for (int i = 1; i <= 1; i++)
            {
                GameObject firePrefab = Instantiate(fire, new Vector3(Mathf.RoundToInt(x), Mathf.RoundToInt(y), 0), fire.transform.rotation);
                firePrefab.transform.SetParent(canvas.transform, false);
            }
            StartCoroutine(SideFire(x, y, j));
        }
    }

    public IEnumerator SideFire(float x, float y, int j)
    {
        for (int i = 1; i <= j; i++)
        {
            GameObject firePrefab = Instantiate(fire, new Vector3(x, y + 50 * i, 0), Quaternion.identity);
            firePrefab.transform.SetParent(canvas.transform, false);
            CheckColorClose(firePrefab);
            yield return new WaitForSeconds(0.02f);
            if (firePrefab.gameObject != null)
            {
                CheckColorOpen(firePrefab);
            }
        }
        for (int i = 1; i <= j; i++)
        {
            GameObject firePrefab = Instantiate(fire, new Vector3(x, y - 50 * i, 0), Quaternion.identity);
            firePrefab.transform.SetParent(canvas.transform, false);
            CheckColorClose(firePrefab);
            yield return new WaitForSeconds(0.02f);
            if (firePrefab.gameObject != null)
            {
                CheckColorOpen(firePrefab);
            }
        }
        for (int i = 1; i <= j; i++)
        {
            GameObject firePrefab = Instantiate(fire, new Vector3(x - 50 * i, y, 0), Quaternion.identity);
            firePrefab.transform.SetParent(canvas.transform, false);
            CheckColorClose(firePrefab);
            yield return new WaitForSeconds(0.02f);
            if (firePrefab.gameObject != null)
            {
                CheckColorOpen(firePrefab);
            }
        }
        for (int i = 1; i <= j; i++)
        {
            GameObject firePrefab = Instantiate(fire, new Vector3(x + 50 * i, y, 0), Quaternion.identity);
            firePrefab.transform.SetParent(canvas.transform, false);
            CheckColorClose(firePrefab);
            yield return new WaitForSeconds(0.02f);
            if (firePrefab.gameObject != null)
            {
                CheckColorOpen(firePrefab);
            }
        }
    }



    void CheckColorClose(GameObject firePrefab)
    {
        image = firePrefab.GetComponent<Image>();
        Color imageColor = image.color;
        imageColor.a = 0f;
        image.color = imageColor;
    }

    void CheckColorOpen(GameObject firePrefab)
    {
        image = firePrefab.GetComponent<Image>();
        Color imageColor = image.color;
        imageColor.a = 255f;
        image.color = imageColor;
    }
}
