# WorkDemoElevator

## Zadání

### Požadavky:

- Výtah může být zavolán z libovolného patra.

- Uživatel zadává, do kterého patra chce jet.

- Výtah vždy začne na prvním patře.

- Pohyb výtahu má být optimalizovaný (například nezastavuje na každém patře, pokud tam není žádný požadavek).

- Předpokládejte, že v každém okamžiku obsluhujete pouze jednoho uživatele.

### Výstup:

- Návrh základní architektury aplikace (popis tříd, metod, případně základní implementace v C#). Kód nemusí být detailní, stačí základní popis funkcionality slovně. Pokud však chcete, můžete navrhnout základní třídy, metody nebo ukázku implementace s využitím jednoduchého pseudokódu nebo C# syntaxe.

- Popis, jak by výtah reagoval na různé situace, například: volání z patra 5, když výtah jede z patra 1 do patra 10.

## Řešení

### Návrh

Jelikož má výtah obsluhovat je jednoho uživatele v daný čas, zavolil jsem triviální implementaci skrz frontu požadavků, kdy jsou požadavky zpracovánvané jeden za druhým v pořadí v jakém přišli. Zpracovávaný požadavek má přednost ikdyž se výtah pohybuje přes patra kde je výtah očekáván.

### Aplikace

Aplikace simuluje pohyb výtahu se zadáním požadavků přes konzoli:

- exit - Ukončí simulaci
- move - Zvolení cesty výtah na dané patro (patro se zadává zvlášť)
- call - Zavolání výtahu z příslušného patra (patro se zadává zvlášť)