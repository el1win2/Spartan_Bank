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
    public GameObject notBanlance; // �ܾ� ���� �г�
    public Text CashTxt; // ����
    public Text BanlanceTxt; // ���� �ܾ�
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
    public void OpenNotBanlance()
    {
        notBanlance.SetActive(true);

    }

    public void CloseNotBanlance()
    {
        notBanlance.SetActive(false);

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
        int banlancetxt = int.Parse(BanlanceTxt.text);

        if(cashtxt >= 10000)
        {
            cashtxt -= 10000;
            banlancetxt += 10000;
            CashTxt.text = cashtxt.ToString();
            BanlanceTxt.text = banlancetxt.ToString();
        } else
        {
            Invoke("OpenNotMoney", 0.0f);
            Invoke("CloseNotMoney", 1.5f);
        }
    }

    public void Deposit30K()
    {
        int cashtxt = int.Parse(CashTxt.text);
        int banlancetxt = int.Parse(BanlanceTxt.text);

        if (cashtxt >= 30000)
        {
            cashtxt -= 30000;
            banlancetxt += 30000;
            CashTxt.text = cashtxt.ToString();
            BanlanceTxt.text = banlancetxt.ToString();
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
        int banlancetxt = int.Parse(BanlanceTxt.text);

        if (cashtxt >= 50000)
        {
            cashtxt -= 50000;
            banlancetxt += 50000;
            CashTxt.text = cashtxt.ToString();
            BanlanceTxt.text = banlancetxt.ToString();
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
        int banlancetxt = int.Parse(BanlanceTxt.text);
        bool b = int.TryParse(depositInput.text, out int InputValue);

        if(!b) InputValue = 0;

        if (cashtxt >= InputValue)
        {
            cashtxt -= InputValue;
            banlancetxt += InputValue;
            CashTxt.text = cashtxt.ToString();
            BanlanceTxt.text = banlancetxt.ToString();
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
        int banlancetxt = int.Parse(BanlanceTxt.text);

        if (banlancetxt >= 10000)
        {
            cashtxt += 10000;
            banlancetxt -= 10000;
            CashTxt.text = cashtxt.ToString();
            BanlanceTxt.text = banlancetxt.ToString();
        }
        else
        {
            Invoke("OpenNotBanlance", 0.0f);
            Invoke("CloseNotBanlance", 1.5f);
        }
    }

    public void Withdraw30K()
    {
        int cashtxt = int.Parse(CashTxt.text);
        int banlancetxt = int.Parse(BanlanceTxt.text);

        if (banlancetxt >= 30000)
        {
            cashtxt += 30000;
            banlancetxt -= 30000;
            CashTxt.text = cashtxt.ToString();
            BanlanceTxt.text = banlancetxt.ToString();
        }
        else
        {
            Invoke("OpenNotBanlance", 0.0f);
            Invoke("CloseNotBanlance", 1.5f);
        }
    }

    public void Withdraw50K()
    {
        int cashtxt = int.Parse(CashTxt.text);
        int banlancetxt = int.Parse(BanlanceTxt.text);

        if (banlancetxt >= 50000)
        {
            cashtxt += 50000;
            banlancetxt -= 50000;
            CashTxt.text = cashtxt.ToString();
            BanlanceTxt.text = banlancetxt.ToString();
        }
        else
        {
            Invoke("OpenNotBanlance", 0.0f);
            Invoke("CloseNotBanlance", 1.5f);
        }
    }

    public void WithdrawInput()
    {
        int cashtxt = int.Parse(CashTxt.text);
        int banlancetxt = int.Parse(BanlanceTxt.text);
        bool b = int.TryParse(withdrawInput.text, out int InputValue);

        if (!b) InputValue = 0;

        if (banlancetxt >= InputValue)
        {
            cashtxt += InputValue;
            banlancetxt -= InputValue;
            CashTxt.text = cashtxt.ToString();
            BanlanceTxt.text = banlancetxt.ToString();
        }
        else
        {
            Invoke("OpenNotBanlance", 0.0f);
            Invoke("CloseNotBanlance", 1.5f);
        }
    }
}
