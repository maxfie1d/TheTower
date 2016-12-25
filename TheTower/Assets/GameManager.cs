﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverUI;
    public GameObject player;
    public Camera mainCamera;
    public Camera fpsCamera;

    private float time = 5.0f;
    private float elapsed = 0.0f;

    // Use this for initialization
    void Start()
    {
        useMainCamera();
        this.GameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            useMainCamera();
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            useFPSCamera();
        }
    }

    public void gotoGameOverState()
    {
        this.player.SendMessage("gotoGameOverState");
        this.mainCamera.SendMessage("activateBlur");
        this.GameOverUI.SetActive(true);
    }

    private void gotoGameState()
    {
        this.player.SendMessage("respawn");
        this.mainCamera.SendMessage("deactivateBlur");
        this.GameOverUI.SetActive(false);
    }

    public void onBackToTitlePageClick()
    {
        Debug.Log("Back to title page button was clicked");
        SceneManager.LoadScene("TitleScene");
    }

    public void onContinueButtonClick()
    {
        this.gotoGameState();
        Debug.Log("Continue button was clicked");
    }

    private void useMainCamera()
    {
        this.mainCamera.gameObject.SetActive(true);
        this.fpsCamera.gameObject.SetActive(false);
    }

    private void useFPSCamera()
    {
        this.mainCamera.gameObject.SetActive(false);
        this.fpsCamera.gameObject.SetActive(true);
    }
}
