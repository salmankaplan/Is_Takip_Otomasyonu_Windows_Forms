MsSql ile oluşturalan databasedeki Yetki Id'sine göre kullanıcı girişinin olduğu windows form projesidir. Admin ve Personel olarak iki tane yetki vardır. Admin tüm sayfaları görüntüleme ve tüm sayfalarda işlem yapma yetkisine sahiptir. Personel ise sadece kendi bölümlerini görüntüleyebilir ve yapabileceği işlemler kısıtlıdır. Tcp haberleşmesi mevcut olan projede Admin olarak giriş yapıp gelen ekranda bildirim butonuna bastığımızda bizden Ip adresi ve Port Numarası isteyecektir. Bu ekranda Ip : 127.0.0.1 Port Numarası : 3535 olarak girdiğimizde bağlantımız gerçekleşir Başka bir ekranda personel olarak girip kendi iş bölümünü tamamlayan personelimiz bölümümü bitir butonuna basarak admine bildirim yollamaktadır. Personel sadece admin online iken bu işlemi yapabilir.