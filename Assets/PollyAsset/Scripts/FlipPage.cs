using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FlipPage : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource = null;
    [SerializeField] private AudioClip flipPage=null;
    
    private enum ButtonType
    {
        NextButton,
        PrevButton
    }
    [SerializeField] private Button nextBtm = null;
    [SerializeField] private Button prevBtm=null;
    [SerializeField] private Button closeBtm=null;

    [SerializeField] private Text headerText1_1 = null;
    [SerializeField] private Text headerText1_2 = null;
    [SerializeField] private Text headerText2_1 = null;
    [SerializeField] private Text headerText2_2 = null;
    
    [SerializeField] private Text bodyText1_1 = null;
    [SerializeField] private Text bodyText1_2 = null;
    [SerializeField] private Text bodyText2_1 = null;
    [SerializeField] private Text bodyText2_2 = null;
    
    [SerializeField] private Text footerText1_1 = null;
    [SerializeField] private Text footerText1_2 = null;
    [SerializeField] private Text footerText2_1 = null;
    [SerializeField] private Text footerText2_2 = null;
    
    
    private Vector3 rotationVector = new Vector3();
    private Vector3 startPosition = new Vector3();
    private Quaternion startRotation  = new Quaternion();
    private bool isClicked;
    private DateTime startTime;
    private DateTime endTime;
    
 
    void Start()
    {
        startRotation = transform.rotation;
        startPosition = transform.position;
        
        if (nextBtm != null)
        {
            nextBtm.onClick.AddListener(() => turnOnePagetBtm_Click(ButtonType.NextButton));
        }
        if (prevBtm != null)
        {
            prevBtm.onClick.AddListener(() => turnOnePagetBtm_Click(ButtonType.PrevButton));
        }
        if (closeBtm != null)
        {
            closeBtm.onClick.AddListener(() => CloseBookBtm_Click());
        }
    }
    //Awake
    private void Awake()
    {
        AppEvents.OpenBook += new EventHandler(openBookBtn_Click);
    }

    // Update is called once per frame
    void Update()
    {
        if (isClicked)
        {
            transform.Rotate(rotationVector * Time.deltaTime);
            endTime = DateTime.Now;
            if ((endTime - startTime).TotalSeconds>=1)
            {
                isClicked = false;
                transform.position = startPosition;
                transform.rotation = startRotation;
                
                SetVisibleText();
            }

            
        }
    }

    private void openBookBtn_Click(object sender, EventArgs e)
    {
        Page pge = Page.GetRandomPage();

        Page.CurrentPage1 = 0;
        Page.CurrentPage2 = 1;
        
        prevBtm.gameObject.SetActive(false);
        nextBtm.gameObject.SetActive(false);

        if (pge.Pages.Count>2)
            nextBtm.gameObject.SetActive(true);
        
        SetVisibleText();
    }

    private void ClearVisibleText()
    {
        Page pge = Page.RandomPage;

        string footer1 = "";
        string footer2 = "";
        string body1 = "";
        string body2 = "";
        string header1 = "";
        string header2 = "";
        
        headerText1_1.text = header1;
        headerText1_2.text = header2;
        
        footerText1_1.text = footer1;
        footerText1_2.text = footer2;
        
        bodyText1_1.text = body1;
        bodyText1_2.text = body2;
        
        
    }
    
    private void SetFlipPageText(int leftPage, int rightPage)
    {
        Page pge = Page.RandomPage;

        string footerR = "";
        string footerL = "";
        string bodyR = "";
        string bodyL = "";
        string headerR = "";
        string headerL = "";

        if (rightPage < pge.Pages.Count)
        {
            footerR = String.Format("{0} / {1}", rightPage + 1, pge.Pages.Count);
            bodyR = pge.Pages[rightPage];
            headerR = pge.Title;
        }
        if (leftPage < pge.Pages.Count)
        {
            footerL = String.Format("{0} / {1}", leftPage + 1, pge.Pages.Count);
            bodyL = pge.Pages[leftPage];
            headerL = pge.Title;
        }

        headerText2_1.text = headerL;
        headerText2_2.text = headerR;
        
        footerText2_1.text = footerL;
        footerText2_2.text = footerR;
        
        bodyText2_1.text = bodyL;
        bodyText2_2.text = bodyR;
    }
    
    private void SetVisibleText()
    {
        Page pge = Page.RandomPage;

        string footer1 = "";
        string footer2 = "";
        string body1 = "";
        string body2 = "";
        string header1 = "";
        string header2 = "";

        if (Page.CurrentPage1 < pge.Pages.Count)
        {
            footer1 = String.Format("{0} / {1}", Page.CurrentPage1+1, pge.Pages.Count);
            body1 = pge.Pages[Page.CurrentPage1];
            header1 = pge.Title;
        }
        if (Page.CurrentPage2 < pge.Pages.Count)
        {
            footer2 = String.Format("{0} / {1}", Page.CurrentPage2+1, pge.Pages.Count);
            body2 = pge.Pages[Page.CurrentPage2];
            header2 = pge.Title;
        }

        headerText1_1.text = header1;
        headerText1_2.text = header2;
        
        footerText1_1.text = footer1;
        footerText1_2.text = footer2;
        
        bodyText1_1.text = body1;
        bodyText1_2.text = body2;
    }
    
    private void turnOnePagetBtm_Click(ButtonType type)
    {
        isClicked = true;
        startTime = DateTime.Now;
        nextBtm.gameObject.SetActive(true);
        prevBtm.gameObject.SetActive(true);
        
        if (type == ButtonType.NextButton)
        {
            rotationVector = new Vector3(0,180,0);

            SetFlipPageText(Page.CurrentPage2, Page.CurrentPage2 + 1);

            Page.CurrentPage1 += 2;
            Page.CurrentPage2 += 2;
            Page pge = Page.RandomPage;
            
           // SetVisibleText();
           ClearVisibleText();

            if ((Page.CurrentPage2 >= pge.Pages.Count) || (Page.CurrentPage1 >= pge.Pages.Count))
            {
                nextBtm.gameObject.SetActive(false);
            }
        }
        else if (type == ButtonType.PrevButton)
        {
            Vector3 newRotation = new Vector3(startRotation.x, 180, startRotation.z);
            transform.rotation = Quaternion.Euler(newRotation);
            rotationVector = new Vector3(0,-180,0);
            
            SetFlipPageText(Page.CurrentPage1 - 1, Page.CurrentPage1);
            
            Page.CurrentPage1 -= 2;
            Page.CurrentPage2 -= 2;
            
            SetVisibleText();
            
            if ((Page.CurrentPage2 <= 0) || (Page.CurrentPage1 <= 0))
            {
                prevBtm.gameObject.SetActive(false);
            }
        }
    }

    private void CloseBookBtm_Click()
    {
        AppEvents.CloseBookFunktion();
    }
}
