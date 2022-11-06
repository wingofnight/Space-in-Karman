using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOOKbutton : MonoBehaviour
{
    [SerializeField] private GameObject bookPrefab;

    private bool seeBook = false;
    // Start is called before the first frame update

    public void seeShowBook()
    {
        bookPrefab.SetActive(true);
    }
}
