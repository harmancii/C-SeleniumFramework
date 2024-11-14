# C-SeleniumFramework
Bu repo, C# ve Selenium kullanarak basit bir Google arama testi yapmayı sağlayan bir framework içeriyor.

1. Gereksinimler
.NET SDK: İndir
Google Chrome: En güncel sürüm
ChromeDriver: Chrome tarayıcınızla uyumlu sürümü İndir
IDE: Visual Studio Code veya herhangi bir C# IDE (C# eklentisi yüklü olmalı)

2. Projeyi Klonlama ve Yükleme
Projeyi klonlayın ve gerekli bağımlılıkları yüklemek için:

git clone https://github.com/harmancii/C-SeleniumFramework
cd <project-directory>
dotnet restore

3. NuGet Paketlerini Yükleme
Projede kullanılan NuGet paketlerini yüklemek için:

dotnet add package Selenium.WebDriver
dotnet add package Selenium.Chrome.WebDriver
dotnet add package NUnit
dotnet add package NUnit3TestAdapter
dotnet add package Selenium.Support

4. Testi Çalıştırma
Testleri çalıştırmak için terminalde şu komutu kullanın:

dotnet test
Testlerin başarılı geçmesi durumunda, sonuç şu şekilde görünecektir:

Test Run Successful.
Total tests: 1
     Passed: 1
 Total time: 0.234s
 
5. Testlerin Yapılandırılması
Setup(): ChromeDriver başlatılır.
TestGoogleSearch(): Google'a gidilir, arama yapılır, sonuç kontrol edilir.
TearDown(): Test sonrası tarayıcı kapatılır.

6. Çalışma Ortamı Gereksinimleri
Google Chrome ve ChromeDriver uyumluluğu kontrol edilmelidir.
Testleri çalıştırmadan önce ChromeDriver'ı PATH'e ekleyin.
