 #  ----   Otel Otomasyon ve Yönetim Sistemi
## -Proje Tanıtımı
Bu proje, bir otel rezervasyon ve yönetim sistemi geliştirmek amacıyla Windows Forms kullanılarak hazırlanmıştır. Proje, nesne yönelimli programlama prensipleri ve  n katmanlı mimari yapısı üzerine inşa edilmiştir. Sistemin temel işlevleri, rezervasyon yönetimi, oda yönetimi, müşteri yönetimi ve fatura takibini kapsamaktadır.Veritabanı olarak MySQL, dil ve platform olarak C# Form App kullanılmıştır.

 ## Diyagramlar
 ### -Class Diyagramı
Class Diyagraminda oluşturulan sınıflar arası ilişkiler ve kullanılan metotlar gösterilmiştir. Yönetici (Admin) ile diğer sınıflar arasındaki ilişki Aggregaiton (zorunlu olmayan), Oda (Room) - Rezervasyon (Reservation) arasındaki ilişki composotion (zorunlu), Reservasyon (Resevation) - Fatura (Payment) arasındaki ilişki composition (zorunlu), diğerleri aralarındaki ilişki ise 'aggregation'dır.

 ![Classdiyagrami](https://github.com/user-attachments/assets/f24cb698-1bed-4519-9bdb-f8729f4112eb)

### -ER Diyagramı
Rezervasyon (Reservation)  - Oda(Room) bire bir, Fatura (Payment) - Müşteri (Customer) bire bir, Müşteri (Customer) - Rezervasyon (Reservation) birden çoğa, Rezervasyon (Reservation) - Fatura (Payment) bire bir bunların Yönetici (Admin) ile ilişkileri birden çoğadır. 
PK (Primary Key): Oluşturulan tabloda veri sıraları benzersiz olmasılıdır.
FK (Foreign Key): Bir tanloda benzersiz kayıt oluşturmayı sağlayan sütunun başka bir tabloda bulunmasıdır.
![ERdiyagrami](https://github.com/user-attachments/assets/880c4b3c-d956-41c3-a205-a14f7dcc7ae3)

### -Use-Case Diyagramı
Use Case Diyagramlar, tüm işlevselliği göstermek için kullanılır.
![UseCasediyagrami](https://github.com/user-attachments/assets/20ca06dd-8dfe-430c-95a7-950b7dca16fd)

