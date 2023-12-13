using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Pay; // 시작 패널
    public GameObject PayDeposit; // 입금 패널
    public GameObject PayWithdraw; // 출금 패널
    public GameObject notMoney; // 현금 부족 패널
    public GameObject notBanlance; // 잔액 부족 패널
    public Text CashTxt; // 현금
    public Text BanlanceTxt; // 통장 잔액
    public Text depositInput; // 입금 입력값
    public Text withdrawInput; // 출금 입력값

    // 입금 패널 열기
    public void OpenDeposit()
    {
        Pay.SetActive(false);
        PayDeposit.SetActive(true);
    }

    // 출금 패널 열기
    public void OpenWithdraw()
    {
        Pay.SetActive(false);
        PayWithdraw.SetActive(true);
    }

    // 현금 부족 열고 닫기
    public void OpenNotMoney()
    {
        notMoney.SetActive(true);

    }

    public void CloseNotMoney()
    {
        notMoney.SetActive(false);

    }

    // 잔액 부족 열고 닫기
    public void OpenNotBanlance()
    {
        notBanlance.SetActive(true);

    }

    public void CloseNotBanlance()
    {
        notBanlance.SetActive(false);

    }

    // 처음으로 돌아가기
    public void back()
    {
        PayDeposit.SetActive(false);
        PayWithdraw.SetActive(false);
        Pay.SetActive(true);
    }

    // 입금하기
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

    // 출금하기
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
