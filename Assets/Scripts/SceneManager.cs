using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {

    private Vector2 firstPressPos, secondPressPos, currentSwipe;
    public GameObject bgFather, BG1, BG2, BG3, BG4;
    public static bool isGarden = false;
    public static int polem;

    public void Update()
    {
        Swipe();
    }
    public void Swipe()
    {

        if (Input.GetMouseButtonDown(0))
        {
            //save began touch 2d point
            firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        }
        if (Input.GetMouseButtonUp(0))
        {

            //save ended touch 2d point
            secondPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            //create vector from the two points
            currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

            //normalize the 2d vector
            currentSwipe.Normalize();

            //swipe down
            if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f && bgFather.transform.position.x == 0)
            {
                float novaPositionY = bgFather.transform.position.y;
                if (novaPositionY == 0f)
                {
                    novaPositionY = 10f;
                    isGarden = true;
                }
                bgFather.transform.position = new Vector3(bgFather.transform.position.x, novaPositionY, bgFather.transform.position.z);
            }

            //swipe up
            if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
            {
                float novaPositionY = bgFather.transform.position.y;
                if (novaPositionY == 10f)
                {
                    novaPositionY = 0f;
                    isGarden = false;
                }
                bgFather.transform.position = new Vector3(bgFather.transform.position.x, novaPositionY, bgFather.transform.position.z);
            }

            if (bgFather.transform.position.y == 0) { 
            //swipe RIGHT
            if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
            {
                float novaPositionX = bgFather.transform.position.x;
                if (novaPositionX == 0f)
                {
                    novaPositionX = -5.6f;
                }
                else if (novaPositionX == 5.6f)
                {
                    novaPositionX = 0f;
                }

                bgFather.transform.position = new Vector3(novaPositionX, bgFather.transform.position.y, bgFather.transform.position.z);

            }
            //swipe LEFT
            if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
            {
                float novaPositionX = bgFather.transform.position.x;
                if (novaPositionX == 0f)
                {
                    novaPositionX = 5.6f;
                }
                else if (novaPositionX == -5.6f)
                {
                    novaPositionX = 0f;
                }

                bgFather.transform.position = new Vector3(novaPositionX, bgFather.transform.position.y, bgFather.transform.position.z);
            }
        }
        }
    }


    /* public void Update()
  {

      if (Input.touchCount > 0)
      {            
          Touch touch = Input.GetTouch(0);

          // Move the cube if the screen has the finger moving.
          switch (touch.phase)
          {
              case TouchPhase.Began:
                  Debug.Log("Tocou");
                  break;
          }

      }
  }


      Vector3 startPos;
      float minSwipeDistX, minSwipeDistY;
      bool isJump, isSwipe, isTouch = false;
      float playerVelocity;
      float wTime = 0.05f;

      public void Update(){


      if(Input.touchCount > 0)
      {
          Touch touch = Input.touches[0];

          switch (touch.phase)
          {
              case TouchPhase.Began:
                  startPos = touch.position;
                  StartCoroutine(Jump());
                  break;
              case TouchPhase.Moved:
                  isSwipe = true;
                  float swipeDistHorizontal = (new Vector3(touch.position.x, 0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;
                  float swipeDistVertical = (new Vector3(0, touch.position.y, 0) - new Vector3(0, startPos.y, 0)).magnitude;
                  if (swipeDistHorizontal > minSwipeDistX)
                  {
                      float swipeValue = Mathf.Sign(touch.position.x - startPos.x);
                      if (swipeValue > 0 && !isTouch)//to right swipe
                      {
                          isTouch = true;
                          StartCoroutine(Right(wTime));
                      }
                      else if (swipeValue < 0 && !isTouch)//to left swipe
                      {
                          isTouch = true;
                          StartCoroutine(Left(wTime));
                      }
                  }

                  //add swipe to up
                  if(swipeDistVertical > minSwipeDistY)
                  {
                      float swipeValue = Mathf.Sign(touch.position.y - startPos.y);
                      if(swipeValue > 0 && !isTouch)
                      {
                          isTouch = true;
                          StartCoroutine(Jump2());
                      }
                  }
                  break;
              case TouchPhase.Ended:
                  isSwipe = false;
                  isTouch = false;
                  break;
          }
      }
      }

          IEnumerator Jump2()
      {
          yield return new WaitForSeconds(0.05f);
          if(playerVelocity <= 0.2f)
          {
              Debug.Log("Swipe Up");
          }
      }

      IEnumerator Jump()
      {
          if (!isSwipe)
          {
              yield return new WaitForSeconds(0.05f);
              if (!isSwipe && playerVelocity <= 0.2f)
              {
                  Debug.Log("Tap");

              }
              else
              {
                  yield break;
              }
          }
          else
          {
              yield break;
          }
      }

      private IEnumerator Right(float waittime)
      {
          yield return new WaitForSeconds(waittime);
          Debug.Log("Right");

      }

      private IEnumerator Left(float waittime)
      {
          yield return new WaitForSeconds(waittime);
          Debug.Log("Left");



      }*/
}