# Macchina di Turing
Questo programma è un simulatore di una <a href="https://en.wikipedia.org/wiki/Universal_Turing_machine"> macchina di Turing universale.

Esempi di comandi corretti
--
```
S0-0=S1,1,>
S1-0=S1,STOP 
```

Inizialmente si scrive la tupla che corrisponde allo stato e valore corrente. Si comincia a scrivere la parola <b>"S"</b>, per intendere "stato", seguito da un numero, ossia il numero dello stato.

Esempi:
---
```
S0
S2
S8
```

Successivamente si scrive <b>"-"</b>, per indicare che stiamo per dichiarare il valore della cella da controllare, seguito da un numero o uno spazio vuoto. I numeri possono essere <b>0</b> o <b>1</b>, mentre lo spazio vuoto si rappresenta come <b>"_"</b>.

Esempi:
---
```
S0-1
S2-0
S8-_
```  

Dopo aver scritto la tupla, si comincia a scrivere l'azione da eseguire in caso il nastro si trovi in questo caso. Prima di tutto, si inserisce un <b>"="</b> per separare la tupla dall'azione. Da qui in poi, si possono aggiungere fino a un massimo di 4 operazioni, con almeno 1 obbligatoria. Ogni azione è separata da una <b>virgola</b>.
Le azioni disponibili sono le seguenti:

* Cambia stato
* Cambia valore
* Sposta il nastro a destra / sinistra
  - Per spostare il nastro a destra, si scrive <b>">"</b>
  - Per spostare il nastro a sinistra, si scrive </b>">"</b>
* Ferma il simulatore
  - Per fermare il simulatore, si scrive <b>"STOP"</b>.
 
<b>NOTA BENE</b>: per cambiare stato o valore, la sintassi da utilizzare è quella usata precedentemente, <b>unica differenza è l'uso della virgola invece di "-" per separare ogni azione!</b>

Esempi:
---
```
S0-1=S1,<
S2-0=S3,STOP
S8-_=S9,0,>
```  
