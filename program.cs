// ConsoleApp4.Program
// Token: 0x06000004 RID: 4 RVA: 0x00002324 File Offset: 0x00000524
[CompilerGenerated]
internal static bool? <Main>g__dogrulas0_1(long tckimlik, ref Program.<>c__DisplayClass0_0 A_1)
{
	bool? durum;
	try
	{
		using (KPSPublicSoapClient servis = new KPSPublicSoapClient())
		{
			durum = new bool?(servis.TCKimlikNoDogrula(tckimlik, A_1.girilen_ad, A_1.girilen_soyad, A_1.girilen_dogum_yili));
		}
	}
	catch
	{
		durum = null;
		Console.Write("Hata Oluþtu");
	}
	return durum;
}


// ConsoleApp4.Program
// Token: 0x06000003 RID: 3 RVA: 0x000021BC File Offset: 0x000003BC
[CompilerGenerated]
internal static string <Main>g__TC_TAMAMLA0_0(string no)
{
	string[] numberArray = new string[no.Length];
	int counter = 0;
	for (int i = 0; i < no.Length; i++)
	{
		numberArray[i] = no.Substring(counter, 1);
		counter++;
	}
	int toplam_tek = Convert.ToInt32(numberArray[0]) + Convert.ToInt32(numberArray[2]) + Convert.ToInt32(numberArray[4]) + Convert.ToInt32(numberArray[6]) + Convert.ToInt32(numberArray[8]);
	toplam_tek *= 7;
	int toplam_cift = Convert.ToInt32(numberArray[1]) + Convert.ToInt32(numberArray[3]) + Convert.ToInt32(numberArray[5]) + Convert.ToInt32(numberArray[7]);
	toplam_tek -= toplam_cift;
	int onuncusayi = toplam_tek % 10;
	int cikan = Convert.ToInt32(numberArray[0]) + Convert.ToInt32(numberArray[1]) + Convert.ToInt32(numberArray[2]) + Convert.ToInt32(numberArray[3]) + Convert.ToInt32(numberArray[4]) + Convert.ToInt32(numberArray[5]) + Convert.ToInt32(numberArray[6]) + Convert.ToInt32(numberArray[7]) + Convert.ToInt32(numberArray[8]) + toplam_tek;
	int onbirinci = cikan % 10;
	return string.Concat(new object[]
	{
		numberArray[0],
		numberArray[1],
		numberArray[2],
		numberArray[3],
		numberArray[4],
		numberArray[5],
		numberArray[6],
		numberArray[7],
		numberArray[8],
		onuncusayi,
		onbirinci
	});
}

// ConsoleApp4.Program
// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
private static void Main(string[] args)
{
	Program.<>c__DisplayClass0_0 CS$<>8__locals1 = default(Program.<>c__DisplayClass0_0);
	Console.Write(" T.C. Kimlik Numarası: ");
	string hedef_tckimlik = Console.ReadLine();
	Console.Write("\nAd : ");
	CS$<>8__locals1.girilen_ad = Console.ReadLine();
	Console.Write("\nSoyad : ");
	CS$<>8__locals1.girilen_soyad = Console.ReadLine();
	Console.Write("\nDoğum Yılı : ");
	CS$<>8__locals1.girilen_dogum_yili = Convert.ToInt32(Console.ReadLine());
	int islem_sec = Convert.ToInt32(Console.ReadLine());
	int sayac = 1;
	long son_tc_bulundu = 0L;
	bool? sorgula = Program.<Main>g__dogrulas0_1(long.Parse(Program.<Main>g__TC_TAMAMLA0_0(hedef_tckimlik)), ref CS$<>8__locals1);
	while (sorgula == false)
	{
		bool flag = islem_sec == 1;
		long islem;
		if (flag)
		{
			islem = long.Parse(hedef_tckimlik) - (long)(29999 * sayac);
		}
		else
		{
			islem = long.Parse(hedef_tckimlik) + (long)(29999 * sayac);
		}
		son_tc_bulundu = islem;
		sorgula = Program.<Main>g__dogrulas0_1(long.Parse(Program.<Main>g__TC_TAMAMLA0_0(islem.ToString())), ref CS$<>8__locals1);
		Console.WriteLine(sayac.ToString() + sorgula.ToString());
		sayac++;
	}
	Console.Write("\n\n Bulunan TC : " + Program.<Main>g__TC_TAMAMLA0_0(son_tc_bulundu.ToString()));
	Console.ReadKey();
}
