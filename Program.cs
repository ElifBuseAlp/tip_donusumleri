// tip dönüşümleri çalışma


//-------implicit conversion-------
byte a = 3;
sbyte b = 4;
short c = 5;

int d = a + b + c;
Console.WriteLine(d);

long e = d;
Console.WriteLine(e);

float f = e;
Console.WriteLine(f);

string g = "buse";
char h = 'p';
object i = g + h + d ;
Console.WriteLine(i);

//-----explicit conversion-------

int j = 3;
byte k = (byte)j;
Console.WriteLine(k);

float l = 10.8f;
byte m = (byte)l;
Console.WriteLine(m);

//-------ToString()------------

int n = 10;
string o = n.ToString();
Console.WriteLine(o);

string p = 14.8f.ToString();
Console.WriteLine(p);

//-------system.convert()-------

string s1 = "10", s2 = "20";
int sayi1, sayi2;
int toplam;

sayi1 = Convert.ToInt32(s1);
sayi2 = Convert.ToInt32(s2);
Console.WriteLine(sayi1+sayi2);

//-------parse()-----------

string metin1 = "25";
string metin2 = "15,25";

int rakam1 = Int32.Parse(metin1);
double double1 = Double.Parse(metin2);

Console.WriteLine(rakam1);
Console.WriteLine(double1);











Console.ReadLine();
