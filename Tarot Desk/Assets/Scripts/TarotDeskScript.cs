using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TarotDeskScript : MonoBehaviour 
{
	
	private int[] random_Number = new int[9];
	private int[] random_Nunber_Looking = new int[9];
	private string CardName;
	private int HowMuchCardYouWant;
	public bool WouldYouWant = true;
	private string Looking;
	private int HowManyTurnCounter = 0;
	// Start is called before the first frame update

	bool TarotDeskController( int Turn,int HowMuchCardYouWant)
    {
        for (int i = 0; i < HowMuchCardYouWant; i++)
        {
            if (Turn != i)
            {
                if (random_Number[i] == random_Number[Turn])
                {
                    return true;
                }
            }
        }
        return false;
    }

	void Update()
    {
		TextMeshProUGUI Card = GameObject.Find("Canvas/Card").GetComponent<TextMeshProUGUI>();
		TextMeshProUGUI myTextTurn = GameObject.Find("Canvas/Turn").GetComponent<TextMeshProUGUI>();

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
		if (WouldYouWant)
		{
			for (int Card_Number = 0; Card_Number < HowMuchCardYouWant; Card_Number++)
			{
				do
				{
					random_Number[Card_Number] = Random.Range(0, 78);
					random_Nunber_Looking[Card_Number] = Random.Range(0, 2);
				} while (TarotDeskController( Card_Number, HowMuchCardYouWant));
			}
			for (int WritingTurn = 0; WritingTurn < HowMuchCardYouWant; WritingTurn++)
			{
				Looking = ForLookingArray(WritingTurn);
				WritingTurn++;
				CardName += WritingTurn +". Kart ";
				WritingTurn--;
				CardName += Looking;
				CardName += Writing_to_Log (WritingTurn);
				Card.text = CardName;
				CardName += "\n";			}
			CardName = "";
			WouldYouWant = false;
			myTextTurn.text = HowManyTurnCounter +" Kez kart �ektin. ";
			HowManyTurnCounter++;
		}
		else
        {
			HowMuchCardYouWant = 0;
			WouldYouWant = NumericControl();
		}
	}
	string ForLookingArray (int turn)
    {
		if (random_Nunber_Looking[turn] == 0)
        {
			return "";
		}
		else if (random_Nunber_Looking[turn] == 1)
        {
			return "[Ters] ";
        }
		else
        {
			return "error ";
        }
			

	} 
	bool NumericControl()
	{
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
		{
			HowMuchCardYouWant = 1;
			return true;
		}
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
		{
			HowMuchCardYouWant = 2;
			return true;
		}
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
        {
			HowMuchCardYouWant = 3;
			return true;
		}
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))
        {
			HowMuchCardYouWant = 4;
			return true;
		}
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5))
        {
			HowMuchCardYouWant = 5;
			return true;
		}
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6))
        {
			HowMuchCardYouWant = 6;
			return true;
		}
		else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7))
        {
            HowMuchCardYouWant = 7;
            return true;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8))
        {
            HowMuchCardYouWant = 8;
            return true;
        }
		else if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9))
		{
			HowMuchCardYouWant = 9;
			return true;
		}
		else
        {
            return false;
        }
	}
	

	string Writing_to_Log(int writing_turn)
	{
		string Turner;
		if (random_Number[writing_turn] == 0)
			Turner = "Joker, The Fool";
		else if (random_Number[writing_turn] == 1)
			Turner = "Sihirbaz, The Magican";
		else if (random_Number[writing_turn] == 2)
			Turner = "Azize, The High Priestess";
		else if (random_Number[writing_turn] == 3)
			Turner = "�mparatori�e, The Empress";
		else if (random_Number[writing_turn] == 4)
			Turner = "�mparator, The Emperor";
		else if (random_Number[writing_turn] == 5)
			Turner = "Aziz, The Hierophant";
		else if (random_Number[writing_turn] == 6)
			Turner = "A��klar, The Lovers";
		else if (random_Number[writing_turn] == 7)
			Turner = "Sava� Arabas�, The Chariot";
		else if (random_Number[writing_turn] == 8)
			Turner = "G��, Strength";
		else if (random_Number[writing_turn] == 9)
			Turner = "Ermi�, Rhe Hermit";
		else if (random_Number[writing_turn] == 10)
			Turner = "Kader �ark�, Wheel of Fortune";
		else if (random_Number[writing_turn] == 11)
			Turner = "Adalet, Justice";
		else if (random_Number[writing_turn] == 12)
			Turner = "As�lan Adam, The Hanged Man";
		else if (random_Number[writing_turn] == 13)
			Turner = "�l�m, Death";
		else if (random_Number[writing_turn] == 14)
			Turner = "Denge, Temperance";
		else if (random_Number[writing_turn] == 15)
			Turner = "�eytan, The Devil";
		else if (random_Number[writing_turn] == 16)
			Turner = "Y�k�lan Kule, The Tower";
		else if (random_Number[writing_turn] == 17)
			Turner = "Y�ld�z, The Star";
		else if (random_Number[writing_turn] == 18)
			Turner = "Ay, The Moon";
		else if (random_Number[writing_turn] == 19)
			Turner = "G�ne�, The Sun";
		else if (random_Number[writing_turn] == 20)
			Turner = "Mahkeme, The Last Judgement";
		else if (random_Number[writing_turn] == 21)
			Turner = "D�nya, The World";
		else if (random_Number[writing_turn] == 22)
			Turner = "De�nek As�";
		else if (random_Number[writing_turn] == 23)
			Turner = "De�nek �kilisi";
		else if (random_Number[writing_turn] == 24)
			Turner = "De�nek ��l�s�";
		else if (random_Number[writing_turn] == 25)
			Turner = "De�nek D�rtl�s�";
		else if (random_Number[writing_turn] == 26)
			Turner = "De�nek Be�lisi";
		else if (random_Number[writing_turn] == 27)
			Turner = "De�nek Alt�l�s�";
		else if (random_Number[writing_turn] == 28)
			Turner = "De�nek Yedilisi";
		else if (random_Number[writing_turn] == 29)
			Turner = "De�nek Sekizlisi";
		else if (random_Number[writing_turn] == 30)
			Turner = "De�nek Dokuzlusu ";
		else if (random_Number[writing_turn] == 31)
			Turner = "De�nek Onlusu ";
		else if (random_Number[writing_turn] == 32)
			Turner = "De�nek Prensi ";
		else if (random_Number[writing_turn] == 33)
			Turner = "De�nek ��valyesi";
		else if (random_Number[writing_turn] == 34)
			Turner = "De�nek Krali�esi";
		else if (random_Number[writing_turn] == 35)
			Turner = "De�nek Kral�";
		else if (random_Number[writing_turn] == 36)
			Turner = "Kupa As�";
		else if (random_Number[writing_turn] == 37)
			Turner = "Kupa �kilisi";
		else if (random_Number[writing_turn] == 38)
			Turner = "Kupa ��l�s�";
		else if (random_Number[writing_turn] == 39)
			Turner = "Kupa D�rtl�s�";
		else if (random_Number[writing_turn] == 40)
			Turner = "Kupa Be�lisi";
		else if (random_Number[writing_turn] == 41)
			Turner = "Kupa Alt�l�s�";
		else if (random_Number[writing_turn] == 42)
			Turner = "Kupa Yedilisi";
		else if (random_Number[writing_turn] == 43)
			Turner = "Kupa Sekizlisi";
		else if (random_Number[writing_turn] == 44)
			Turner = "Kupa Dokuzlusu";
		else if (random_Number[writing_turn] == 45)
			Turner = "Kupa Onlusu";
		else if (random_Number[writing_turn] == 46)
			Turner = "Kupa Prensi";
		else if (random_Number[writing_turn] == 47)
			Turner = "Kupa ��valyesi";
		else if (random_Number[writing_turn] == 48)
			Turner = "Kupa Krali�esi";
		else if (random_Number[writing_turn] == 49)
			Turner = "Kupa Kral�";
		else if (random_Number[writing_turn] == 50)
			Turner = "K�l�� As�";
		else if (random_Number[writing_turn] == 51)
			Turner = "K�l�� �kilisi";
		else if (random_Number[writing_turn] == 52)
			Turner = "K�l�� ��l�s�";
		else if (random_Number[writing_turn] == 53)
			Turner = "K�l�� D�rtl�s�";
		else if (random_Number[writing_turn] == 54)
			Turner = "K�l�� Be�lisi";
		else if (random_Number[writing_turn] == 55)
			Turner = "K�l�� Alt�l�s�";
		else if (random_Number[writing_turn] == 56)
			Turner = "K�l�� Yedilisi";
		else if (random_Number[writing_turn] == 57)
			Turner = "K�l�� Sekizlisi";
		else if (random_Number[writing_turn] == 58)
			Turner = "K�l�� Dokuzlusu";
		else if (random_Number[writing_turn] == 59)
			Turner = "K�l�� Onlusu";
		else if (random_Number[writing_turn] == 60)
			Turner = "K�l�� Prensi";
		else if (random_Number[writing_turn] == 61)
			Turner = "K�l�� ��valyesi";
		else if (random_Number[writing_turn] == 62)
			Turner = "K�l�� Krali�esi";
		else if (random_Number[writing_turn] == 63)
			Turner = "K�l�� Kral�";
		else if (random_Number[writing_turn] == 64)
			Turner = "T�ls�m As�";
		else if (random_Number[writing_turn] == 65)
			Turner = "T�ls�m �kilisi";
		else if (random_Number[writing_turn] == 66)
			Turner = "T�ls�m ��l�s�";
		else if (random_Number[writing_turn] == 67)
			Turner = "T�ls�m D�rtl�s�";
		else if (random_Number[writing_turn] == 68)
			Turner = "T�ls�m Be�lisi";
		else if (random_Number[writing_turn] == 69)
			Turner = "T�ls�m Alt�l�s�";
		else if (random_Number[writing_turn] == 70)
			Turner = "T�ls�m Yedilisi";
		else if (random_Number[writing_turn] == 71)
			Turner = "T�ls�m Sekizlisi";
		else if (random_Number[writing_turn] == 72)
			Turner = "T�ls�m Dokuzlusu";
		else if (random_Number[writing_turn] == 73)
			Turner = "T�ls�m Onlusu";
		else if (random_Number[writing_turn] == 74)
			Turner = "T�ls�m Prensi";
		else if (random_Number[writing_turn] == 75)
			Turner = "T�ls�m ��valyesi";
		else if (random_Number[writing_turn] == 76)
			Turner = "T�ls�m Krali�esi";
		else if (random_Number[writing_turn] == 77)
			Turner = "T�ls�m Kral�";
		else
			Turner = "Error";
		return Turner;
	}

	public void OneCardFunc()
	{
		WouldYouWant = true;
		HowMuchCardYouWant = 1;
	}
	public void TwoCardFunc()
	{
		WouldYouWant = true;
		HowMuchCardYouWant = 2;
	}
	public void ThreeCardFunc()
	{
		WouldYouWant = true;
		HowMuchCardYouWant = 3;
	}
	public void FourCardFunc()
	{
		WouldYouWant = true;
		HowMuchCardYouWant = 4;
	}
	public void FiveCardFunc()
	{
		WouldYouWant = true;
		HowMuchCardYouWant = 5;
	}
	public void SixCardFunc()
	{
		WouldYouWant = true;
		HowMuchCardYouWant = 6;
	}
	public void SevenCardFunc()
	{
		WouldYouWant = true;
		HowMuchCardYouWant = 7;
	}
	public void EightCardFunc()
	{
		WouldYouWant = true;
		HowMuchCardYouWant = 8;
	}
}
