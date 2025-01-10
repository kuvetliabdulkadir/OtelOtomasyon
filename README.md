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
![otelgiris](https://github.com/user-attachments/assets/b16d031d-3b01-4c09-8482-815e52cfce42)




