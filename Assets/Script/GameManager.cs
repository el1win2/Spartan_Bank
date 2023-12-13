using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Pay; // ���� �г�
    public GameObject PayDeposit; // �Ա� �г�
    public GameObject PayWithdraw; // ��� �г�
    public GameObject notMoney; // ���� ���� �г�
    public GameObject notbalance; // �ܾ� ���� �г�
    public Text CashTxt; // ����
    public Text balanceTxt; // ���� �ܾ�
    public Text depositInput; // �Ա� �Է°�
    public Text withdrawInput; // ��� �Է°�

    // �Ա� �г� ����
    public void OpenDeposit()
    {
        Pay.SetActive(false);
        PayDeposit.SetActive(true);
    }

    // ��� �г� ����
    public void OpenWithdraw()
    {
        Pay.SetActive(false);
        PayWithdraw.SetActive(true);
    }

    // ���� ���� ���� �ݱ�
    public void OpenNotMoney()
    {
        notMoney.SetActive(true);

    }

    public void CloseNotMoney()
    {
        notMoney.SetActive(false);

    }

    // �ܾ� ���� ���� �ݱ�
    public void OpenNotbalance()
    {
        notbalance.SetActive(true);

    }

    public void CloseNotbalance()
    {
        notbalance.SetActive(false);

    }

    // ó������ ���ư���
    public void back()
    {
        PayDeposit.SetActive(false);
        PayWithdraw.SetActive(false);
        Pay.SetActive(true);
    }

    // �Ա��ϱ�
    public void Deposit10K()
    {
        int cashtxt = int.Parse(CashTxt.text);
        int balancetxt = int.Parse(balanceTxt.text);

        if(cashtxt >= 10000)
        {
            cashtxt -= 10000;
            balancetxt += 10000;
            CashTxt.text = cashtxt.ToString();
            balanceTxt.text = balancetxt.ToString();
        } else
        {
            Invoke("OpenNotMoney", 0.0f);
            Invoke("CloseNotMoney", 1.5f);
        }
    }

    public void Deposit30K()
    {
        int cashtxt = int.Parse(CashTxt.text);
        int balancetxt = int.Parse(balanceTxt.text);

        if (cashtxt >= 30000)
        {
            cashtxt -= 30000;
            balancetxt += 30000;
            CashTxt.text = cashtxt.ToString();
            balanceTxt.text = balancetxt.ToString();
        }
        else
        {
            Invoke("OpenNotMoney", 0.0f);
            Invoke("CloseNotMoney", 1.5f);
        }
    }

    public void Deposit50K()
    {
        int cashtxt = int.Parse(CashTxt.text);
        int balancetxt = int.Parse(balanceTxt.text);

        if (cashtxt >= 50000)
        {
            cashtxt -= 50000;
            balancetxt += 50000;
            CashTxt.text = cashtxt.ToString();
            balanceTxt.text = balancetxt.ToString();
        }
        else
        {
            Invoke("OpenNotMoney", 0.0f);
            Invoke("CloseNotMoney", 1.5f);
        }
    }

    public void DepositInput()
    {
        int cashtxt = int.Parse(CashTxt.text);
        int balancetxt = int.Parse(balanceTxt.text);
        bool b = int.TryParse(depositInput.text, out int InputValue);

        if(!b) InputValue = 0;

        if (cashtxt >= InputValue)
        {
            cashtxt -= InputValue;
            balancetxt += InputValue;
            CashTxt.text = cashtxt.ToString();
            balanceTxt.text = balancetxt.ToString();
        }
        else
        {
            Invoke("OpenNotMoney", 0.0f);
            Invoke("CloseNotMoney", 1.5f);
        }
    }

    // ����ϱ�
    public void Withdraw10K()
    {
        int cashtxt = int.Parse(CashTxt.text);
        int balancetxt = int.Parse(balanceTxt.text);

        if (balancetxt >= 10000)
        {
            cashtxt += 10000;
            balancetxt -= 10000;
            CashTxt.text = cashtxt.ToString();
            balanceTxt.text = balancetxt.ToString();
        }
        else
        {
            Invoke("OpenNotbalance", 0.0f);
            Invoke("CloseNotbalance", 1.5f);
        }
    }

    public void Withdraw30K()
    {
        int cashtxt = int.Parse(CashTxt.text);
        int balancetxt = int.Parse(balanceTxt.text);

        if (balancetxt >= 30000)
        {
            cashtxt += 30000;
            balancetxt -= 30000;
            CashTxt.text = cashtxt.ToString();
            balanceTxt.text = balancetxt.ToString();
        }
        else
        {
            Invoke("OpenNotbalance", 0.0f);
            Invoke("CloseNotbalance", 1.5f);
        }
    }

    public void Withdraw50K()
    {
        int cashtxt = int.Parse(CashTxt.text);
        int balancetxt = int.Parse(balanceTxt.text);

        if (balancetxt >= 50000)
        {
            cashtxt += 50000;
            balancetxt -= 50000;
            CashTxt.text = cashtxt.ToString();
            balanceTxt.text = balancetxt.ToString();
        }
        else
        {
            Invoke("OpenNotbalance", 0.0f);
            Invoke("CloseNotbalance", 1.5f);
        }
    }

    public void WithdrawInput()
    {
        int cashtxt = int.Parse(CashTxt.text);
        int balancetxt = int.Parse(balanceTxt.text);
        bool b = int.TryParse(withdrawInput.text, out int InputValue);

        if (!b) InputValue = 0;

        if (balancetxt >= InputValue)
        {
            cashtxt += InputValue;
            balancetxt -= InputValue;
            CashTxt.text = cashtxt.ToString();
            balanceTxt.text = balancetxt.ToString();
        }
        else
        {
            Invoke("OpenNotbalance", 0.0f);
            Invoke("CloseNotbalance", 1.5f);
        }
    }
}
