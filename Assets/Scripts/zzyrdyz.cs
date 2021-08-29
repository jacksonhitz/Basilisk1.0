using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zzyrdyz : MonoBehaviour
{
    // Just a test
   public string menuName;
   public bool open;
   
   public void Open()
   {
       open = true;
       gameObject.SetActive(true);

   }

   public void Close()
   {
       open = false;
       gameObject.SetActive(false);
   }
}
