# NtierMVCProjeYeni
Sivasın daglarında yazılmıs olan bır projenın katmanlı mımarısınde gezmek ıstermısın ?

Gorevler Dagılımı

1-	Master  = “Furkan”
2-	Masterın gorevlerı 
a.	Master oncelıkle Ntier Patterni kuracak 
b.	Referansları verir
c.	EntityFramework 6.2.0 kullanılacak cunkı 6.3.0 surumunde hata vardır
d.	Calısanların yaptıkları yuklemelerı mastera entegre eder ve master yuzunden bır sorun cıkarsa bunu master halleder
Furkan = Modelin icerisinde Entites  ve Enum bolumunu yapmak
Enes = Mycontext bolumunu yapacak
Esra = Bll katmanında unitofworks kullanılacak ve dizayn patterini olarak singleton patern kullanılacak
Furkan = MVCUI kısmında Control ve Viewlara bakacak.
Ntier Mimari Katmanları
a)	Project.Model =>  Furkan
b)	Project.Dal => Enes Connection String master yazıcak
c)	Project.BLL =>  Esra
d)	Project.MVCUI =>  Furkan

Onemlı Konu : Calısanlar bır commit ve push yaptıktan sonar master’a bılgı vermelıler ve yaptıkları ıslemlerı dogru bır sekılde commit yaparken yazmalılar.

