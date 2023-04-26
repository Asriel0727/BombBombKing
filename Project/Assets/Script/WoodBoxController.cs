using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodBoxController : MonoBehaviour
{
    private Image image;

    private Collider2D mycollider = new Collider2D();


    void Start()
    {
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fire"))
        {
            image = this.gameObject.GetComponent<Image>();
            mycollider = this.gameObject.GetComponent<Collider2D>();
            if(!mycollider.isTrigger)
            {
                mycollider.isTrigger = !mycollider.isTrigger;
                this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1f, 1f);
                image.tag = "Untagged";
                Color imageColor = image.color;
                imageColor.a = 0f;
                image.color = imageColor;
            }

        }
    }
}
