# Poznamky ku projektu DM-internat #
<b>Novinky</b>

- - - - - - - - - - - - - -

Dorobit gombiky pre vymazanie poloziek pre ciselniky: Skupiny, titul pred, typ ubytovania, typ izby

- - - - - - - - - - - - - -

Pre kartu novy student pridat blok zamerany na ubytovanie. Bolo by tam:

-Typ ubytovania - SS student/VS student/Turista - vytvorena tabulka - SPRAVENE -

-Zaciatok ubytovania - datum - vytvorený stlpec v tabulke student - SPRAVENE

-celkova zaplatena suma (na zaciatku nula) - tu by sa to mozno dalo riesit aj cez samostatnu tabulku, ak chceme pamatat kedy aka platba prisla - ?????
> Treba nam dajak pamatat a evidovat platby. Na to by sluzila podtabulka -pre kazdeho ubytovaneho- kde by boli dva stlpce suma a datum. (cize kolko a kedy zaplatene) Tym by sme mali historiu platieb, z ktorej (cez sucet sum) by sme vedeli vypocitat celkovu zaplatenu sumu

> Celkovu zaplatenu sumu vieme potom vyuzit pri odubytovani. Rozdiel medzi datumom ubytovania a datumom odubytovania krat cena za danu izbu by nam dal sumu, ktora ak by bola rozna od celkovej sumy tak by znamenala ze dany clovek ma este daco doplatit, resp. ma preplatok


-Typ izby - jedno/dvoj/trojpostelova - vytvorena tabulka, pridany id stlpec do tabulky - SPRAVENE

-Cislo izby - bud cez ciselniky alebo priamo (ak nechceme neskor robit selekty podla izby) -??????
> Polozka cislo izby ak dame cez ciselniky, tak si potom vieme spravit zostavy typu vypis studentov z izby 123B (ked to nebude cez ciselniky nezarucime ze napr ten kto zada noveho ubytovaneho neda 123 B resp 1 2 3 B atd.)

-Cena za izbu - tahane cez ciselnik (najlepsie v zavislosti na type izby a type ubytovania)  - tu by mozno do buducna bolo dobre mysliet na mozne zadavanie zliav (napr studentska karta) - ??? mozno dobre dat ku typu izby????

> Cena za izbu je viazana na velkost izby a aj na typ ubytovaneho, takze mohli by sme to mat tak, ze ak pri novom ubytovanom sa zada napr jednopostelova, turista, tak vybehne automaticky cena ze 120sk

> S tymi zlavami by to mohlo byt zase cez drop down menu ze 10%, 20%, ... a tym by sa to zohladnovalo pri vypocte ceny za ubytovanie