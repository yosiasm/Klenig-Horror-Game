using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class pitutur : MonoBehaviour, IPointerClickHandler {

	string  jaw;
	string  ind;
	void Start () {
		string[] jawa = {
			"Narimo ing pandum.",
			"Gusti iku cedhak tanpa senggolan, adoh tanpa wangenan.",
			"Ala lan becik iku gegandhengan, Kabeh kuwi saka kersaning Pangeran.",
			"Natas, nitis, netes.",
			"Alam iki sejatining Guru.",
			"Golek sampurnaning urip lahir batin lan golek kusumpurnaning pati.",
			"Manungsa mung ngunduh wohing pakarti.",
			"Asih, asah, asuh.",
			"Kudu rukun marang tonggo teparo.",
			"Eling, mawas diri, waspada.",
			"Budha, budhi.",
			"Heneng, Hening.",
			"Ora kena nglarani.",
			"Rela lan legawa lair trusing batin.",
			"Kawula mung saderma, mobah-mosik kersaning Hyang sukmo.",
			"Adigang, adigung, adiguno.",
			"Ambeg utomo, andhap asor.",
			"Aja mbedakake marang sapadha-padha.",
			"Mohon, mangesthi, mangastuti, marem.",
			"Titikane Aluhur, Alusing Solah Tingkah Budi Bahasane Lan Legawaning Ati, Darbe Sipat Berbudi Bawaleksana.",
			"Manunugsa saderma nglakoni, kadya drama upamane.",
			"Rame ing gawe sepi ing pamrih, memayu hayuning bawana.",
			"Ngelmu kang nyata, karya reseping ati.",
			"Ala Lan Becik Kui Dumunung Ana Awake Dhewe.",
			"Sing Bisa Dadi Utusaning Pengeran Iku Ora Mung Jalma Manungsa Wae.",
			"Asu rebutan balung.",
			"Basa iku busananing bangsa.",
			"Cecak nguntal cagak.",
			"Cedhak kebo gupak.",
			"Dhemit ora ndulit, setan ora doyan.",
			"Esok dhele sore tempe.",
			"Kakehan gludhug, kurang udan.",
			"Lelembut iku ana rong warna, yakuwi kang nyilakani lan kang mitulungi.",
			"Mburu uceng kelangan dhelek.",
			"Nguyahi banyu segara.",
			"Gusti mboten sare."
		};
		string[] indo = {
			"Terima segala rintangan dengan ikhlas.",
			"Tuhan dekat, namun tidak tersentuh oleh tubuh dan jangkauan pikiran.",
			"Kebaikan dan kejahatan ada bersama-sama, itu semua adalah kehendak Tuhan.",
			"Dari Tuhan kita ada, bersama Tuhan kita hidup, dan bersatu dengan Tuhan ketika kembali.",
			"Alam adalah guru yang sejati.",
			"Cari kesejahteraan hidup di dunia dan akhirat.",
			"Baik dan buruk adalah akibat dari perbuatan manusia itu sendiri.",
			"Hidup penuh kasih, belajar dan peduli kepada sesama.",
			"Bertentangga dengan senantiasa rukun dan damai.",
			"Hidup dengan penuh kesadaran, pahami diri sendiri dan tetap waspada.",
			"Mereka yang hidupnya tercerahkan akan mencerahkan yang lain.",
			"Kedamaian di dalam hati akan mengantarkan pada kedamaian hidup.",
			"Jangan melukai.",
			"Ikhlas lahir batin.",
			"Lakukan yang kita bisa, setelahnya serahkan kepada Tuhan.",
			"Jaga kelakuan, jangan sombong dengan kekuatan, kedudukan, ataupun latar belakang.",
			"Selalu menjadi yang utama tapi selalu rendah hati.",
			"Hargai perbedaan.",
			"Selalu meminta petunjuk Tuhan untuk menyelaraskan antara ucapan dan perbuatan agar dapat berguna bagi sesama.",
			"Ciri-ciri orang luhur ialah tingkah laku dan budi yang halus, keikhlasan hati, dan sedia bekorban, tanpa mendahulukan kepentingan pribadi.",
			"Manusia sekedar menjalani, diibaratkan seperti drama.",
			"Banyak bekarya, tanpa menuntut balas jasa, menyelamatkan kesejahteraan dunia.",
			"hati yang baik dihasilkan dari pengetahuan sejati.",
			"Baik dan buruk ada pada diri kita sendir.",
			"Yang dapat menjadi utusan tuhan itu bukan hanya manusia.",
			"Berdebat hal yang sepele tak ada yang mau mengalah.",
			"Budi pekerti bisa terlihat dari tutur kata yang diucap.",
			"Suatu keinginan yang tidak seimbang dengan kekuatan.",
			"Berteman dan bergaul dengan orang jahat pasti nantinya akan ikut-ikutan.",
			"Lepas dari mara bahaya.",
			"mudah terbawa angin dan tidak punya pendirian.",
			"Banyak bicara tanpa kenyataan.",
			"Mahluk halus itu ada dua macam, yaitu yang mencelakakan dan yang menolong manusia.",
			"Mencari sesuatu yang kecil malah kehilangan sesuatu yang lebih berharga.",
			"Melakukan hal yang sia-sia.",
			"Tuhan tidak tidur."
		};

		int a=Random.Range (0, jawa.Length);
		jaw = jawa [a];
		ind = indo [a];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public Text t;
	bool huh;
	public void OnPointerClick(PointerEventData eventData)
	{
		if (huh) {
			t.text = ind;
			huh = false;
		} else {
			t.text = jaw;
			huh = true;
		}

	}
}
