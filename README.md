# Veri-Yapilari-Odevlendirme-2

Soru 2: Kuyruk Implemantasyonu

Turgutlu bankasına gelen 20 müşteri bir kuyruk oluşturmaktadır. Her bir müşterinin kendine özel bir müşteri numarası ve 60 - 600 saniye arasında rastgele bir işlem süresi bulunmaktadır.
Öncelikle, FIFO mantığına dayalı dairesel bir kuyruk tasarlamanız istenmektedir.

* Her bir müşterinin işi biterek kuyruktan çıkarıldığında işlem tamamlanma süresini yani işlem
süresi dâhil ne kadar süre kuyrukta kaldığını, liste halinde yazdırınız.
* Ayrıca, 20 müşteri için ortalama işlem tamamlanma süresini de hesaplayıp yazdırınız.

Aynı işlemi aynı müşteri değerleri kullanarak öncelikli kuyruk için tekrarlayınız. Kuyruğu, işlem süresi en kısa olan müşteri ilk (öncelikli) olarak hizmet alacak şekilde tasarlayınız (kuyruk elemanları küçükten büyüğe sıralı).

* Her bir müşteri, işi biterek kuyruktan çıkarıldığında işlem tamamlanma süresini liste halinde yazdırınız.
* 20 müşteri için ortalama işlem tamamlanma süresini de hesaplayıp yazdırınız.
* Bu yapıda, hangi müşterilerin FIFO kuyruğa göre, daha az beklediğini listeleyiniz (işlem süreleri ve sıra numaraları ile). Ortalama işlem tamamlanma süresindeki kazancı (a şıkkına göre) (fark ve %) hesaplayınız.
Aynı işlemi öncelik kuyruğu elemanlarını büyükten küçüğe sıralı tutarak tekrarlayınız.
