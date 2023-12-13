using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public GameObject Pay;
    public GameObject PayDeposit;
    public GameObject PayWithdraw;

    public void back()
    {
        PayDeposit.SetActive(false);
        PayWithdraw.SetActive(false);
        Pay.SetActive(true);
    }
}
