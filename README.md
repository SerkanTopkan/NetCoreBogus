# NetCoreBogus

Hangi uygulamayı geliştirirsek geliştirelim, günün sonunda yazdığımız uygulamaları test etmek için Fake data olarak tabir edilen datalara ihtiyaç bulunmakta. Takdir edersiniz ki data bulmak da kolay iş değil :)

Bu işlem için ya uygulamanın istediği türden dataları manuel olarak oluşturmak zorundayız ya da veritabanımızda olan gerçek proje datalarını sadece test amaçlı veritabanından çekmek zorundayız. Eğer halihazırda içinde data bulunduran bir veritabanımız da yok ise bu işlem daha da zorlaşacaktır.

İşte tam bu noktada **Brian Chavez**’in geliştirdiği **Bogus Kütüphanesi** devreye girmekte. 

Bogus Kütüphanesi, bizlere projemizdeki kullandığımız model sınıflarımıza ve metotlarımıza uygun, istediğimiz türde ve istediğimiz sayıda fake-data oluşturma fırsatı sunuyor. 

İsim, soyisim, ID gibi temel nitelikler(property) dışında; Adres, yakıt türü, şirket ismi, meslek, telefon numarası gibi yüzlerce çeşit veriyi istediğimiz sayıda bizim için üretip kullanımımıza sunuyor.

Install-Package Bogus ile kütüphaneyi projemize ekliyoruz.

Devamı kodlar içinde :)
