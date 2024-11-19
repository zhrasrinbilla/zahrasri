
using System; 
class Calculator 
{ 
 static void Main() 
 { 
 Console.WriteLine("Kalkulator Sederhana"); 
 Console.WriteLine("===================="); 
 // Minta pengguna memasukkan angka pertama 
 Console.Write("Masukkan angka pertama: "); 
 double angka1 = Convert.ToDouble(Console.ReadLine()); 
 // Minta pengguna memasukkan operator 
 Console.Write("Masukkan operator (+, -, *, /): "); 
 char operasi = Console.ReadKey().KeyChar; 
 Console.WriteLine(); 
 // Minta pengguna memasukkan angka kedua 
 Console.Write("Masukkan angka kedua: "); 
 double angka2 = Convert.ToDouble(Console.ReadLine()); 
 double hasil = 0; 
 // Periksa operasi yang dipilih dan lakukan perhitungan 
 switch (operasi) 
 { 
 case '+': 
 hasil = angka1 + angka2; 
 break; 
 case '-': 
 hasil = angka1 - angka2; 
 break; 
 case '*': 
 hasil = angka1 * angka2; 
 break; 
 case '/': 
 if (angka2 != 0) 
 { 
 hasil = angka1 / angka2; 
 } 
 else 
 { 
 Console.WriteLine("Kesalahan: Pembagian dengan nol tidak diperbolehkan."); 
 return; 
 } 
 break; 
 default: 
 Console.WriteLine("Operator tidak valid."); 
 return; 
 } 
 // Tampilkan hasil 
 Console.WriteLine("Hasil: " + hasil); 
 } 
}