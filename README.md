 #  ----   Otel Otomasyon ve Yönetim Sistemi
##  Proje Tanıtımı
Bu proje, bir otel rezervasyon ve yönetim sistemi geliştirmek amacıyla Windows Forms kullanılarak hazırlanmıştır. Proje, nesne yönelimli programlama prensipleri ve  n katmanlı mimari yapısı üzerine inşa edilmiştir. Sistemin temel işlevleri, rezervasyon yönetimi, oda yönetimi, müşteri yönetimi ve fatura takibini kapsamaktadır.Veritabanı olarak MySQL, dil ve platform olarak C# Form App kullanılmıştır.


## Proje Mimarisi
- Entity Layer
- DataAccess Layer
- Presentation Layer
- Business Logic Layer


 ## Diyagramlar
 ### -Class Diyagramı
Class Diyagraminda oluşturulan sınıflar arası ilişkiler ve kullanılan metotlar gösterilmiştir. Yönetici (Admin) ile diğer sınıflar arasındaki ilişki Aggregaiton (zorunlu olmayan) Reservasyon (Resevation) - Fatura (Payment) arasındaki ilişki composition (zorunlu), diğer sınıfların aralarındaki ilişki ise 'aggregation'dır.

![Classdiyagrami](https://github.com/user-attachments/assets/7c2ec3ee-d83e-42ea-9dbd-b1c01a4b4180)


### -ER Diyagramı
Rezervasyon (Reservation)  - Oda(Room) bire bir, Fatura (Payment) - Müşteri (Customer) bire bir, Müşteri (Customer) - Rezervasyon (Reservation) birden çoğa, Rezervasyon (Reservation) - Fatura (Payment) bire bir bunların Yönetici (Admin) ile ilişkileri birden çoğadır. 
PK (Primary Key): Oluşturulan tabloda veri sıraları benzersiz olmasılıdır.
FK (Foreign Key): Bir tanloda benzersiz kayıt oluşturmayı sağlayan sütunun başka bir tabloda bulunmasıdır.
![ERdiyagrami](https://github.com/user-attachments/assets/880c4b3c-d956-41c3-a205-a14f7dcc7ae3)

### -Use-Case Diyagramı
Sistemin işlevselliğini açıklamak için kullanılır. Use Case Diyagramlar detayları göstermekten ziyade tüm işlevselliği göstermek için kullanılır.
![UseCasediyagrami](https://github.com/user-attachments/assets/3ad1a182-8d73-4732-8fd7-1f457cb5ecca)

## Proje Görselleri
- Giriş Ekranı
+ ![otelgiris](https://github.com/user-attachments/assets/b16d031d-3b01-4c09-8482-815e52cfce42)

- Yönetici Giriş Ekranı
+ ![yoneticigiris](https://github.com/user-attachments/assets/080c949d-55d7-43b7-9cb2-aec9e0612c80)

- Yönetici İşlem Ekranı
+ ![yoneticiilemleri](https://github.com/user-attachments/assets/3ef420f6-efdf-41e7-86eb-fdbac2bf0046)

- Yönetici Kayıt Ekranı
+ ![yoneticikayit](https://github.com/user-attachments/assets/a4877ca9-b8d3-4056-a31e-c4308c809f48)
  
- Oda Yönetim Ekranı
+ ![odayonetimi](https://github.com/user-attachments/assets/6d573fa4-ebe9-4fe9-b44f-3aecf7dfdb51)

- Mevcut Oda Bilgilerini Düzenleme Ekranı
+ ![odabilgileriniduzenle](https://github.com/user-attachments/assets/566e8f39-7821-4a3d-99b8-d82bbf171e45)

- Müşteri Yönetim Ekranı
+ ![musteriyonetimi](https://github.com/user-attachments/assets/4e0a504a-72e9-4bc1-a050-7f2d3f513fcd)

- Mevcut Müşteri Bilgileirni Düzenleme Ekranı
+ ![musteribilgileriniduzenle](https://github.com/user-attachments/assets/b68a9d0c-385c-4925-97a7-85e1e3807a69)

- Müşterinin Oluşturulan Rezervasyonlarını Görüntüleme Ekranı
+ ![musterininrezervasyonları](https://github.com/user-attachments/assets/06709495-ce66-444b-a45b-f51d4f89a6a9)

- Rezervasyon Yönetim Ekranı
+ ![rezervasyonyonetimi](https://github.com/user-attachments/assets/8bf3a3ce-eac3-400e-b808-15507ec5370d)

- Rezervasyon Oluşturma Ekranı
+ ![rezervasyonolustur](https://github.com/user-attachments/assets/968597d9-240a-4338-8175-2c0c9bc7946b)


- Fatura Yönetim Ekranı
+ ![faturayonetimi](https://github.com/user-attachments/assets/b43679cb-fb93-4290-a7ad-0b3a5d7e5f6b)

- Fatura DEtayları Görüntüleme Ekranı
+ ![faturadetayları](https://github.com/user-attachments/assets/26206098-8ed0-4ada-96c4-d3f07d885377)















