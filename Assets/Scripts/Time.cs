using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/**
@brief Класс для работы с игровым временем
@detailed Осуществляет расчет и отображение даты в игре. 
Правила создания времени:
 Стража - время в Риме между сменами двух караулов. В сутках четыре стражи.
 Цикл - четыре стражи в Риме.
 	утро (первая стража), 
 	день (вторая стража), 
 	вечер(третья стража), 
 	ночь (четвёртая стража).
 Декада - десять циклов. 
 	Названия декад: 
 		примум, 
 		секундо, 
 		терциос, 
 		квартус,
 		квинтус, 
 		сексто, 
 		септимо, 
 		октаво, 
 		нона, 
 		децима.
 Каждый примум, каждой декады в центуме это праздник в честь которого называется вся декада.
 	Праздники по порядку:
		День Сотворения ­ Креационис
		День Анеглов Господних ­ Ангелус
		День Славы Б­жьей ­ Глория
		День Хвалы ­ Грация
		День Праведников ­ Сантос
		День Надежды ­ Спеи
		День Спасителя ­ Сальватор 
		День Вознесения ­ Ансенсион
		День Апостолов ­  Апостолес
		День Исхода ­ Экзодус
 Центум - десять декад.
 Центумы называются по порядковому номеру, от начала правления текущего Папы.

 Пример даты: "Третья стража, квинтус Сальватор 26­го центума Папы Пия III­го."
*/

public class Time : MonoBehaviour {
	Text TimeText;

	string[] guardName = {
		"Утро", 
		"День", 
		"Вечер", 
		"Ночь"}; 
	string[] decadeName = {
		"примум",
		"секундо",
		"терциос",
		"квартус",
		"квинтус",
		"сексто",
		"септимо",
		"октаво",
		"нона",
		"децима"
	};
	string[] holidaysName = {
		"Креационис",
		"Ангелус",
		"Глория",
		"Грация",
		"Сантос",
		"Спеи",
		"Сальватор",
		"Ансенсион",
		"Апостолес",
		"Экзодус"
	};
	// TODO: проверить хватит ли запаса времени для долгой игры.
	// uint max = 4,294,967,295 / (4 * 10 * 10) = ~ 10 737 418 игровых лет. 
	static uint now = 0;

	void OnLevelWasLoaded(int level){
		UpdateTime();
	}

	public void FaseOut(){
		now++;
		UpdateTime();
	}

	string BuildTimeString(uint currentTime) {
		string currentGuard = guardName [currentTime % 4];
		string currentDecade = decadeName [(currentTime / 4) % 10];
		string currentHolidays = holidaysName [(currentTime / (4 * 10)) % 10];
		string currentCentum = (1 + currentTime / (4 * 10 * 10)).ToString();
		// TODO: добавить поддержку смен Пап.
		return string.Format ("{0}, {1} {2} {3}го центума Папы Пия III­го.", currentGuard, currentDecade, currentHolidays, currentCentum);
	}

	void UpdateTime(){
		TimeText = GameObject.Find ("TimeText").GetComponent<Text> ();
		TimeText.text = BuildTimeString (now);
	}
}
