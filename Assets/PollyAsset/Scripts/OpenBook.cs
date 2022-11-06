using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class OpenBook : MonoBehaviour
{
    [SerializeField] private Button openBtm=null;
    [SerializeField] private Button closeBtm=null;
    [SerializeField] AudioSource _audioSource=null;
    [SerializeField] private AudioClip openBook =null;
    [SerializeField] private AudioClip closeBookAudioClip =null;
    [SerializeField] private GameObject openedBook = null;
    [SerializeField] private GameObject insaidBackCover = null;
    private Vector3 rotationVector;
    private bool isOpenClicked;
    private bool isCloseCliked;
    private DateTime startTime;
    private DateTime endTime;

    private Quaternion startRotation = new Quaternion();
    void Start()
    {
        startRotation = transform.rotation;
        
        
        if (openBtm != null)
        {
            openBtm.onClick.AddListener(() => openBtm_Click());
        }

        AppEvents.CloseBook += new EventHandler(closeBook_Click);
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpenClicked || isCloseCliked)
        {
            transform.Rotate(rotationVector*Time.deltaTime);
            endTime = DateTime.Now;
            if (isOpenClicked)
            {
                if ((endTime - startTime).TotalSeconds >= 1)
                {
                    isOpenClicked = false;
                    gameObject.SetActive(false);
                    insaidBackCover.SetActive(false);
                    openedBook.SetActive(true);
                    
                    AppEvents.OpenBookFunktion();

                    Vector3 newRotation = new Vector3(startRotation.x, 180, startRotation.z);
                    transform.rotation = Quaternion.Euler(newRotation);
                }
            }

            if (isCloseCliked)
            {
                if ((endTime - startTime).TotalSeconds >= 1)
                {
                    isCloseCliked = false;
                    
                    Vector3 newRotation = new Vector3(startRotation.x, 0, startRotation.z);
                    transform.rotation = Quaternion.Euler(newRotation);
                }
            }
        }
    }

    private void openBtm_Click()
    {
        isOpenClicked = true;
        startTime = DateTime.Now;
        rotationVector = new Vector3(0,180,0);
        PlaySound();
    }
    
    private void closeBook_Click(object sender, EventArgs e)
    {
        gameObject.SetActive(true);
        openedBook.SetActive(false);
        insaidBackCover.SetActive(true);
        
        isCloseCliked = true;
        startTime = DateTime.Now;
        rotationVector = new Vector3(0, -180, 0);
        PlaySoundClose();
        Invoke("Hide", 1.5f);
        //PlaySound();
    }

    public void Hide()
    {
        this.transform.parent.gameObject.SetActive(false);
    }

    private void PlaySound()
    {
        if ((_audioSource != null) && (openBook != null))
        {
            _audioSource.PlayOneShot(openBook);
           
        }
    }

    private void PlaySoundClose()
    {
        if ((_audioSource != null) && (closeBookAudioClip != null))
        {
            _audioSource.PlayOneShot(closeBookAudioClip);
           
        }
    }
}
