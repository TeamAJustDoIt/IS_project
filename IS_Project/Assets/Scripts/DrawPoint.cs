using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class DrawPoint : MonoBehaviour
{
    public Dropdown dropdownStart;
    public Dropdown dropdownFinish;

    public GameObject startImage;
    public GameObject finalImage;
	public int currPlace;
	Vector3 v;

    void Start()
    {
        startImage.SetActive(false);
        finalImage.SetActive(false);
        dropdownStart.onValueChanged.AddListener(delegate {
            OnMyValueChange(dropdownStart);
        });
        dropdownFinish.onValueChanged.AddListener(delegate {
            OnYhValueChange(dropdownFinish);
        });
    }

    public void OnMyValueChange(Dropdown dd)
    {
        startImage.SetActive(true);
        chooseChelik(dd.value, startImage);
    }

    public void OnYhValueChange(Dropdown dd)
    {
        finalImage.SetActive(true);
        chooseChelik(dd.value, finalImage);
    }

    public void chooseRoom(int room, GameObject image)
    {
        double x = 0;
        double y = 0;
        switch (room)
        {
            case 0://Комната №1
                x = 2.5;
                y = -2.5;
                DrawCircle(x, y, image);
                break;
            case 1://Левая лестница
                x = -5.8;
                y = 2.5;
                DrawCircle(x, y, image);
                break;
            case 2: //зимний сад
                x = 0.1;
                y = -1.3;
                DrawCircle(x, y, image);
                break;
            case 3: //Дубовая комната
                x = -7.2;
                y = 2.5;
                DrawCircle(x, y, image);
                break;
            case 4: //лестница правая 1 этаж
                x = 0.4;
                y = 2.4;
                DrawCircle(x, y, image);
                break;
            case 5: //Туалет
                x = 5.8;
                y = -1.8;
                DrawCircle(x, y, image);
                break;
            case 6://северный парадный балкон
                x = -2.6;
                y = 3.6;
                DrawCircle(x, y, image);
                break;
            case 7: //холл 2 этаж
                x = 5.7;
                y = 0.9;
                DrawCircle(x, y, image);
                break;
            case 8: //Домашняя церковь
                x = 6.2;
                y = 2.7;
                DrawCircle(x, y, image);
                break;
            case 9: //Оранжерея
                x = 0.5;
                y = -4;
                DrawCircle(x, y, image);
                break;
            case 10: //Зимний сад(2)
                x = 0;
                y = 1.5;
                DrawCircle(x, y, image);
                break;
            case 11://Русская гостинная
                x = 2.1;
                y = 1;
                DrawCircle(x, y, image);
                break;
            case 12: //Скобелевский зал
                x = 2;
                y = 2.7;
                DrawCircle(x, y, image);
                break;
            case 13: //Романовский зал
                x = -2.5;
                y = 1;
                DrawCircle(x, y, image);
                break;
            case 14: //Восточный кабинет
                x = -7.3;
                y = -1.1;
                DrawCircle(x, y, image);
                break;
            case 15: //Большой гостиный зал
                x = -4.8;
                y = -0.3;
                DrawCircle(x, y, image);
                break;
            case 16: //Малая гостиная
                x = -4.7;
                y = 1.7;
                DrawCircle(x, y, image);
                break;
            case 17: //Малая гостиная
                x = 7.8;
                y = -1.2;
                DrawCircle(x, y, image);
                break;
            case 18: //Тупиковая
                x = 7.2;
                y = 0.6;
                DrawCircle(x, y, image);
                break;
            default:
                break;
        }
    }

	public void chooseChelik(int room, GameObject image)
	{
		double x = 0;
		double y = 0;
		switch (room)
		{
		case 0://Комната №1
			x = 2.5;
			y = -2.5;
			DrawChelik(x, y, image);
			break;
		case 1://Левая лестница
			x = -5.8;
			y = 2.5;
			DrawChelik(x, y, image);
			break;
		case 2: //зимний сад
			x = 0.1;
			y = -1.3;
			DrawChelik(x, y, image);
			break;
		case 3: //Дубовая комната
			x = -7.2;
			y = 2.5;
			DrawChelik(x, y, image);
			break;
		case 4: //лестница правая 1 этаж
			x = 0.4;
			y = 2.4;
			DrawChelik(x, y, image);
			break;
		case 5: //Туалет
			x = 5.8;
			y = -1.8;
			DrawChelik(x, y, image);
			break;
		case 6://северный парадный балкон
			x = -2.6;
			y = 3.6;
			DrawChelik(x, y, image);
			break;
		case 7: //холл 2 этаж
			x = 5.7;
			y = 0.9;
			DrawChelik(x, y, image);
			break;
		case 8: //Домашняя церковь
			x = 6.2;
			y = 2.7;
			DrawChelik(x, y, image);
			break;
		case 9: //Оранжерея
			x = 0.5;
			y = -4;
			DrawChelik(x, y, image);
			break;
		case 10: //Зимний сад(2)
			x = 0;
			y = 1.5;
			DrawChelik(x, y, image);
			break;
		case 11://Русская гостинная
			x = 2.1;
			y = 1;
			DrawChelik(x, y, image);
			break;
		case 12: //Скобелевский зал
			x = 2;
			y = 2.7;
			DrawChelik(x, y, image);
			break;
		case 13: //Романовский зал
			x = -2.5;
			y = 1;
			DrawChelik(x, y, image);
			break;
		case 14: //Восточный кабинет
			x = -7.3;
			y = -1.1;
			DrawChelik(x, y, image);
			break;
		case 15: //Большой гостиный зал
			x = -4.8;
			y = -0.3;
			DrawChelik(x, y, image);
			break;
		case 16: //Малая гостиная
			x = -4.7;
			y = 1.7;
			DrawChelik(x, y, image);
			break;
		case 17: //Малая гостиная
			x = 7.8;
			y = -1.2;
			DrawChelik(x, y, image);
			break;
		case 18: //Тупиковая
			x = 7.2;
			y = 0.6;
			DrawChelik(x, y, image);
			break;
		default:
			break;
		}
	}

    void OnDestroy()
    {
        dropdownStart.onValueChanged.RemoveAllListeners();
        dropdownFinish.onValueChanged.RemoveAllListeners();
    }

    void DrawCircle(double x, double y, GameObject image)
    {
        v = new Vector3((float)(x), (float)(y), 2);
    }

	void DrawChelik(double x, double y, GameObject image)
	{
		v = new Vector3((float)(x), (float)(y), 2);
		image.transform.position = v;
	}
	void Update()
	{
		if (currPlace != -1) {
			
			float speed = 0.3f;
			if (startImage.transform.position != v) {
				startImage.transform.position = Vector3.MoveTowards (startImage.transform.position, v, speed);
			} else {
			
				if (currPlace < GetComponent<WayFinder> ().neededWay.Count - 1) {
					currPlace++;
					chooseRoom (Convert.ToInt32 (GetComponent<WayFinder> ().neededWay [currPlace]), startImage);
				} else
					currPlace = -1;
				
			}
		}
	}
}
