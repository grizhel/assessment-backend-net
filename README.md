# Adayın Notu

Contact App uygulamasına "pigeon" adını verdim ve aşağıda [1] numaralı url o projenin github'taki sayfasınındır. Kafka kullanımı için de belki ileride kullanabileceğim "dotnet-third-party-integrations-core" nuget projesini oluşturdum. Pigeon uygulamasına assembly olarak ekledim ki sürekli nuget çıkmam gerekmesin diye. Şu an nuget indirilip de pigeon programına bakılabilir.

Readme.md dosyaları oluşturdum. Method'lara comment eklemeye çalıştım ancak Kafka çok zamanımı aldı. Postgresql'i kendi sunucumda kurdum ancak Kafka ram yetersizliğinden dolayı çalışmıyordu, Kafka çalıştrılabilir dosyalarını ve config dosyalarını yine "dotnet-third-party-integrations-core" projesinde yer almaktadır.

Postgresql için connection string'te şifre de bulunmakta. Bilerek o şekilde bıraktım. Zaten sadece bir tane kendi database'inde yetkisi var.

Örnek olarak [1] numaralı linkte açılış sayfasında readme bölümünün en alt kısmında contact ekleyip dönüşün ne olduğu ile ilgili bir çözüm mevcut.

[1] https://github.com/grizhel/pigeon
[2] https://github.com/grizhla/dotnet-third-party-integrations-core

- Emre Yılmaz

# Backend (.NET) Assessment

## Merhaba

Bu değerlendirme işe başvuru sürecindeki adaylar için hazırlanmış olup, katılacak kimselerin yaklaşım ve yetkinliklerini değerlendirmede bizlere yardımcı olmak için tasarlanmıştır.

Değerlendirme dahilinde; belirtilen süre içerisinde aşağıda kapsamı ve detayları belirlenmiş projeyi tamamlamanızı beklemekteyiz. Dikkat edebileceğiniz bir diğer husus ise, bizlerin doğru bir değerlendirme yapmamıza yardımcı olacak şekilde iletebileceğiniz en iyi çalışmayı bizlere teslim ediyor olmanız.

### Senaryo

Birbirleri ile haberleşen minimum iki microservice'in olduğu bir yapı tasarlayarak, basit bir telefon rehberi uygulaması oluşturulması sağlanacaktır.

Beklenen işlevler:

- Rehberde kişi oluşturma
- Rehberde kişi kaldırma
- Rehberdeki kişiye iletişim bilgisi ekleme
- Rehberdeki kişiden iletişim bilgisi kaldırma
- Rehberdeki kişilerin listelenmesi
- Rehberdeki bir kişiyle ilgili iletişim bilgilerinin de yer aldığı detay bilgilerin getirilmesi
- Rehberdeki kişilerin bulundukları konuma göre istatistiklerini çıkartan bir rapor talebi
- Sistemin oluşturduğu raporların listelenmesi
- Sistemin oluşturduğu bir raporun detay bilgilerinin getirilmesi

### Teknik Tasarım

**Kişiler:**
Sistemde teorik anlamda sınırsız sayıda kişi kaydı yapılabilecektir. Her kişiye bağlı iletişim bilgileri de yine sınırsız bir biçimde eklenebilmelidir.

Karşılanması beklenen veri yapısındaki gerekli alanlar aşağıdaki gibidir:

- UUID
- Ad
- Soyad
- Firma
- İletişim Bilgisi
  - Bilgi Tipi: Telefon Numarası, E-mail Adresi, Konum
  - Bilgi İçeriği

**Rapor:**
Rapor talepleri asenkron çalışacaktır. Kullanıcı bir rapor talep ettiğinde, sistem arkaplanda bu çalışmayı darboğaz yaratmadan sıralı bir biçimde ele alacak; rapor tamamlandığında ise kullanıcının "raporların listelendiği" endpoint üzerinden raporun durumunu "tamamlandı" olarak gözlemleyebilmesi gerekmektedir.

Rapor basitçe aşağıdaki bilgileri içerecektir:

- Konum Bilgisi
- O konumda yer alan rehbere kayıtlı kişi sayısı
- O konumda yer alan rehbere kayıtlı telefon numarası sayısı

Veri yapısı olarak da:

- UUID
- Raporun Talep Edildiği Tarih
- Rapor Durumu (Hazırlanıyor, Tamamlandı)

**NOT:** Değerlendirme ile ilgili beklentiler için _Teknik Beklentiler_ bölümünü dikkatli okuyunuz.

### Teknik Beklentiler

- Kullanılacak Teknolojiler:

  - .NET Core
  - Git
  - Postgres veya MongoDB
  - Kafka v.b. Message Queue sistemi

- Kısıtlamalar ve Gereksinimler:
  - Projenin sık commitlerle Git üzerinde geliştirilmesi
  - Git üzerinde master, development branchleri ve sürüm taglemelerinin kullanımı
  - Minimum %60 unit testing code coverage
  - Projenin veritabanını oluşturacak migration yapısının oluşturulmuş olması
  - Projenin nasıl çalıştırılacağına dair README.md dokümantasyonu
  - Servislerin HTTP üzerinden REST veya GraphQL protokolleri üzerinden iletişimi sağlanmalı
  - Rapor kısmındaki asenkron yapının sağlanması için message queue gibi sistemler kullanılmalıdır

### Çalışmanın Tamamlanması

Çalışma tamamlandığında bu codebase'i kişisel git repository'sine aktarmanız, çalışma bitiminde de bu repository adresiyle paylaşmanız beklenecektir.

## Sorularınız

Değerlendirmelerle ilgili sorularınızı [github@setur.com.tr](mailto:github@setur.com.tr) adresine iletebilirsiniz.

### Lisans

[Apache 2.0](LICENSE) ile lisanslanmıştır.
