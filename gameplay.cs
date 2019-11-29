using System.Collections.Generic;
using UnityEngine;

// class definition 
// defines a section of code 
public class FirstScript : MonoBehaviour
{
    // variable 
    // 1 - access permission, type, name
    public GameObject boba_toget;
    public GameObject boba_got;
    public GameObject boba_tower1;
    public GameObject boba_tower2;
    public GameObject boba_tower3;
    public GameObject boba_tower4;
    public GameObject boba_tower5;
    public GameObject boba_tower6;
    public GameObject explosion;
    public GameObject game_over;
    public GameObject step1;
    public GameObject step2;
    public GameObject step3;

    // Start function is called before the first frame update
    // called 1 time
    void Start ()
    {
        Debug.Log ("the game has started");
    }

    // Update function is called once per frame
    void Update()
    {
        if (Input.GetKey ("right")) {
            Move("right");
            transform.Translate (0.1f, 0f, 0f);
        }

        if (Input.GetKey ("left")) {
            Move("left");
            transform.Translate (-0.1f, 0f, 0f);
        }

        if (Input.GetKey ("down")) {
            transform.Translate(0f, -.2f, 0f);
        }

        // high jump right
        if (Input.GetKey ("up")) {
            transform.Translate(0f, .5f, 0f);
        }

        // space bar explosion & reset
        if (boba_tower3.activeSelf && Input.GetKey ("space")) {
            explosion.SetActive(true);
            game_over.SetActive(true);
            boba_toget.SetActive(false); 
            boba_tower1.SetActive(false);
            boba_tower2.SetActive(false);
            boba_tower3.SetActive(false);
            boba_tower4.SetActive(false);
            boba_tower5.SetActive(false);
            boba_tower6.SetActive(false);
        }
    }

    // Flip function 
    public void Move( string direction) {
        var thescale = transform.localScale; // get the trasforms scale

        if (direction == "right") {
            thescale.x = 3f; // flip right
        } else {
            thescale.x = -3f; // flip left
        }
        transform.localScale = thescale;
    }

    void OnCollisionEnter2D (Collision2D hit_object) {

        // get dolphin boba
        if (hit_object.gameObject.name == "bobatoget") {
            Debug.Log ("bobatoget was hit");
            boba_toget.SetActive(false); // hide boba_toget GameObject
            boba_got.SetActive(true); // unhide boba_got GameObj
            step1.SetActive(false);

            if(boba_tower1.activeSelf == false) {
                step2.SetActive(true);
            }

        }

        // // tower 6
        //  if (hit_object.gameObject.name == "vaporstatue" && boba_got.activeSelf && boba_tower5.activeSelf) {
        //     Debug.Log ("vaporstatue was hit 6");
        //     boba_tower6.SetActive(true);
        //     boba_got.SetActive(false);
        //     boba_toget.SetActive(false);
        //     step3.SetActive(false);
        // }

        // // tower 5
        //  if (hit_object.gameObject.name == "vaporstatue" && boba_got.activeSelf && boba_tower4.activeSelf) {
        //     Debug.Log ("vaporstatue was hit 5");
        //     boba_tower5.SetActive(true);
        //     boba_got.SetActive(false);
        //     boba_toget.SetActive(true);
        // }
        // // tower 4
        //  if (hit_object.gameObject.name == "vaporstatue" && boba_got.activeSelf && boba_tower3.activeSelf) {
        //     Debug.Log ("vaporstatue was hit 4");
        //     boba_tower4.SetActive(true);
        //     boba_got.SetActive(false);
        //     boba_toget.SetActive(true);
        // }

        // tower 3
         if (hit_object.gameObject.name == "vaporstatue" && boba_got.activeSelf && boba_tower2.activeSelf) {
            Debug.Log ("vaporstatue was hit 3");
            boba_tower3.SetActive(true);
            boba_got.SetActive(false);
           step3.SetActive(false);
        }
                // tower 2
         if (hit_object.gameObject.name == "vaporstatue" && boba_got.activeSelf && boba_tower1.activeSelf) {
            Debug.Log ("vaporstatue was hit 2");
            boba_tower2.SetActive(true);
            boba_got.SetActive(false);
            boba_toget.SetActive(true);

        }
                 // tower 1
         if (hit_object.gameObject.name == "vaporstatue" && boba_got.activeSelf && (boba_tower1.activeSelf == false)) {
            Debug.Log ("vaporstatue was hit 1");
            boba_tower1.SetActive(true);
            boba_got.SetActive(false);
            boba_toget.SetActive(true);
            step2.SetActive(false);
            step3.SetActive(true);
        }



    }

    }
