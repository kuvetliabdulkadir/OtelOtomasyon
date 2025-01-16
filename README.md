 #  Otel Otomasyon ve Yönetim Sistemi
##  Proje Tanıtımı
Bu proje, bir otel rezervasyon ve yönetim sistemi geliştirmek amacıyla Windows Forms kullanılarak hazırlanmıştır. Proje, nesne yönelimli programlama prensipleri ve  n katmanlı mimari yapısı üzerine inşa edilmiştir. Sistemin temel işlevleri, rezervasyon yönetimi, oda yönetimi, müşteri yönetimi ve fatura takibini kapsamaktadır.Veritabanı olarak MySQL, dil ve platform olarak C# Form App kullanılmıştır.


| Proje Mimarisi |
|----------------------------|
| - Entity Layer |
| - DataAccess Layer |
| - Presentation Layer |
| - Business Logic Layer |


 ## Diyagramlar
 ### Class Diyagramı 
Class Diyagraminda oluşturulan sınıflar arası ilişkiler ve kullanılan metotlar gösterilmiştir. Yönetici (Admin) ile diğer sınıflar arasındaki ilişki Aggregaiton (zorunlu olmayan) Reservasyon (Resevation) - Fatura (Payment) arasındaki ilişki composition (zorunlu), diğer sınıfların aralarındaki ilişki ise 'aggregation'dır.
#
![Classdiyagrami](https://github.com/user-attachments/assets/7c2ec3ee-d83e-42ea-9dbd-b1c01a4b4180)


### ER Diyagramı
Rezervasyon (Reservation)  - Oda(Room) bire bir, Fatura (Payment) - Müşteri (Customer) bire bir, Müşteri (Customer) - Rezervasyon (Reservation) birden çoğa, Rezervasyon (Reservation) - Fatura (Payment) bire bir bunların Yönetici (Admin) ile ilişkileri birden çoğadır. 
PK (Primary Key): Oluşturulan tabloda veri sıraları benzersiz olmasılıdır.
FK (Foreign Key): Bir tanloda benzersiz kayıt oluşturmayı sağlayan sütunun başka bir tabloda bulunmasıdır.
#
![ERdiyagrami](https://github.com/user-attachments/assets/3bdfa2bf-d0fe-46ee-be3a-48915312470b)


### Use-Case Diyagramı
Sistemin işlevselliğini açıklamak için kullanılır. Use Case Diyagramlar detayları göstermekten ziyade tüm işlevselliği göstermek için kullanılır.
#
![UseCasediyagrami](https://github.com/user-attachments/assets/3ad1a182-8d73-4732-8fd7-1f457cb5ecca)
#
#
#
## Projeden Görseller
 | - Giriş Ekranı |
 |----------------------------|
 | ![otelgiris](https://github.com/user-attachments/assets/b16d031d-3b01-4c09-8482-815e52cfce42) |

| Yönetici Giriş Ekranı |
|----------------------------|
| - Yönetici kullanıcı adı ve parolasını girerek sisteme giriş yapmaktadır. |
| ![yoneticigiris](https://github.com/user-attachments/assets/080c949d-55d7-43b7-9cb2-aec9e0612c80) |

| Yönetici İşlem Ekranı |
|----------------------------|
| - Yönetici bütün işlemlere buradan erişim sağlamaktadır. |
| ![yoneticiilemleri](https://github.com/user-attachments/assets/3ef420f6-efdf-41e7-86eb-fdbac2bf0046) |

| Yönetici Kayıt Ekranı |
|----------------------------|
| - Yönetici sisteme yeni bir yönetici kayıt edebilir veya eski yöneticiyi sistemden çıkarabilir. |
| - Sisteme kayıt olurken parola en az 6 karakterli ve en az 1 büyük harf kullanılması zorunlu tutulmuştur. |
| ![yoneticikayit](https://github.com/user-attachments/assets/a4877ca9-b8d3-4056-a31e-c4308c809f48) |

| Oda Yönetim Ekranı |
 |----------------------------|
| - Oda yönetiminde mevcut odaları görüntüleyebilir, odaları kullanıma açık (Available) veya kullanıma kapalı (Unavailable) olarak oda durumunu değiştirebilir. |
| - Yeni oda ekleyip, mevcut odayı sistemden silebilir veya düzenliyebilir. |
| ![odayonetimi](https://github.com/user-attachments/assets/6d573fa4-ebe9-4fe9-b44f-3aecf7dfdb51) |

| Mevcut Oda Bilgilerini Düzenleme Ekranı |
 |----------------------------|
| - Bu ekranda seçilen odanın numarasını, tipini ve fiyatını güncelliyebilir. |
|  ![odabilgileriniduzenle](https://github.com/user-attachments/assets/566e8f39-7821-4a3d-99b8-d82bbf171e45) |

| Müşteri Yönetim Ekranı |
 |----------------------------|
| - Müşteri yönetimde mevcut müşterileri görüntüleyebilir. |
| - Seçilen müşterinin oluşturulan rezervasyonlarını yönetebilir |
| - Yeni müşteri ekleyebilir, mevcut müşteriyi silebilir veya düzenliyebilir. |
| - Bu ekrandan müşteriyi seçerek rezervasyon oluşturma sayfasına yönlendirilir. |
|  ![musteriyonetimi](https://github.com/user-attachments/assets/4e0a504a-72e9-4bc1-a050-7f2d3f513fcd) |

| Mevcut Müşteri Bilgileirni Düzenleme Ekranı |
 |----------------------------|
| - Bu ekranda seçilen müşterinin adını, soyadını, e-posta adresini ve telefon numarasını değiştirebilir. |
|  ![musteribilgileriniduzenle](https://github.com/user-attachments/assets/b68a9d0c-385c-4925-97a7-85e1e3807a69) |

|  Müşterinin Oluşturulan Rezervasyonlarını Görüntüleme Ekranı |
 |----------------------------|
| - Bu ekranda seçilen  müşterinin rezervasyonlarını görüntüleyebilir. |
|  ![musterininrezervasyonları](https://github.com/user-attachments/assets/06709495-ce66-444b-a45b-f51d4f89a6a9) |

| Rezervasyon Yönetim Ekranı |
 |----------------------------|
| - Rezervasyon yönetimde oluşturulan tüm rezervasyonları görüntüleyebilir ve silebilirsiniz. |
| ![rezervasyonyonetimi](https://github.com/user-attachments/assets/8bf3a3ce-eac3-400e-b808-15507ec5370d) |

| Rezervasyon Oluşturma Ekranı |
 |----------------------------|
| - Rezervasyon oluşturma ekranında müşteri yönetim ekranında seçilen müşterinin adına rezervasyon oluşturulur. |
| - Tarih aralığı seçildikten sonra o tarihler arasında uygun (Available) odaları tablo şeklinde ekrana getirilir. |
| - Odayı da seçtikten sonra rezervasyon oluştur butonuna tıkladıktan sonra toplam fiyat hesaplanır ve fatura oluşturulur. |
|  ![rezervasyonolustur](https://github.com/user-attachments/assets/968597d9-240a-4338-8175-2c0c9bc7946b) |


| Fatura Yönetim Ekranı |
 |----------------------------|
| - Oluşturulan rezervasyonların faturaları ekrana yansıtılır. Secılen faturaya çift tıklandığı zaman fatura detayları mesaj kutusu şeklinde ekrana gelir. |
|  ![faturayonetimi](https://github.com/user-attachments/assets/b43679cb-fb93-4290-a7ad-0b3a5d7e5f6b) |

| Fatura Detayları Görüntüleme Ekranı |
 |----------------------------|
| - Fatura detayları: |
|  ![faturadetayları](https://github.com/user-attachments/assets/26206098-8ed0-4ada-96c4-d3f07d885377) |

- Projenin genel yapısı ve işlevi bu şekildedir. Projenin videolu anlatımına linkten ulaşabilirsiniz.
- # LİNK










