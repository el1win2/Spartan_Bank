using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Pay;
    public GameObject PayDeposit;
    public GameObject PayWithdraw;

    public void OpenDeposit()
    {
        Pay.SetActive(false);
        PayDeposit.SetActive(true);
    }
    public void OpenWithdraw()
    {
        Pay.SetActive(false);
        PayWithdraw.SetActive(true);
    }
    public void back()
    {
        PayDeposit.SetActive(false);
        PayWithdraw.SetActive(false);
        Pay.SetActive(true);
    }
}
