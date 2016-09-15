[ ... back  ]( ../README.md)

# Llistes din�miques  

Les llistes din�miques, a difer�ncia de les taules, s�n estructures de dades que poden anar creixent a demanda. No cal que donem una mida inicial de la llista, sin� que la llista anir� allotjant mem�ria a mesura que necessiti afegir nous elements a la llista.

.NET ens dona diferents tipus de llista din�mica, segons les nostres necessitats. Per comenar treballarem amb la d'�s m�s general: _List_
Tanmateix n'hi ha d'altres tipus d'estructures de dades per desar "col�lecions" , entre d'altres:
 * List
 * Queue
 * Stack
 * Dictionary
 
## Inicialitzaci�

La sintaxi d'una llista din�mica b�sica �s:
> List<[tipus de dades]> = new List<tipus de dades]();

```c#
            // Creaci� d'una llista din�mica
            List<string> people = new List<string>();
```
## Afegir elements

```c#
            // Afegir elements a la llista
            people.Add("Maria");
            people.Add("Berta");
            people.Add("Joan");
            people.Add("Pep");
            // Acc�s per �ndex
            people[2] = "Josep";
```
##  Recorreguts

```c#
            // Recorregut per �ndex
            string noms = "";
            for(int n=0;n<people.Count;n++)
            {
                noms += $" - {people[n]} \n";
            }
```

```c#
            // Recorregut amb foreach
            foreach( string p in people )
            {
                noms += $" - {p} \n";
            }
```
## Eliminar elements

```c#
            // Eliminaci� d'un element de la llista
            noms.Remove(2, 1); // esborra l'element amb �ndex 2 ( el tercer )
                               // i reindexa els posteriors
            noms.Remove(2);  // esborra tots els elements de la llista a partir del que 
                            // est� a l'index 2 (incl�s)
```

 





```	
	
 