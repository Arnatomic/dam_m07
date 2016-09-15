# Introducci� al llenguatge C#

 
## Comentaris
```c#
	 //  comentari monol�nea
	 /*   
	   comentari multil�nia
	 */
 ```
##  Sortida / Entrada per consola
```c#
	// Escrivint per consola
	System.Console.WriteLine("");
	// Llegint l'entrada de l'usuari
	string userInput = System.Console.ReadLine();
```

Alternativament, posant un "using" a la part inicial de l'arxiu *.cs
podeu simplificar-ho, podent usar directament el nom de la classe "Console", en comptes del nom complet "System.Console" .
```c#
	using System;
	...
	// Escrivint per consola
	Console.WriteLine("");
	// Llegint l'entrada de l'usuari
	string userInput = Console.ReadLine();
```




-------------------------------------------------------------------------------


## Tipus de dades i variables
### Tipus de dades primitius

Els tipus de dades primitius tenen una mida fixa definida pel runtime de .NET
Les variables de tipus primitius es desen a la pila.

	|Name |	.NET Type 	   |Description 	               |Range (min:max)|
	|-------- | ------------------|-----------------------------|-----------------------------|
	|sbyte 	|System.SByte 	|8-bit signed integer    	|-128:127 (-27:27�1)|
	|short 	|System.Int16 	|16-bit signed integer 	|-32,768:32,767 (-215:215�1)|
	|int 	    | System.Int32 	|32-bit signed integer 	|-2,147,483,648:2,147,483,647 (-231:231�1)|
	|long 	|System.Int64 	|64-bit signed integer 	|-9,223,372,036,854,775,808: 9,223,372,036,854,775,807 (-263:263�1)|
	|byte 	|System.Byte 	   |8-bit unsigned integer 	|  0:255 (0:28�1)|
	|ushort 	|System.UInt16 |16-bit unsigned integer |  0:65,535 (0:216�1)|
	|uint 	   |System.UInt32 	|32-bit unsigned integer|	0:4,294,967,295 (0:232�1)|
	|ulong 	|System.UInt64 |64-bit unsigned integer |   0:18,446,744,073,709,551,615 (0:264�1)|


### Declaraci� i inicialitzaci� de variables

Sintaxi id�ntica a C:

[tipus de dades] [nom variable];

o usant  inicialitzaci� directa:

[tipus de dades] [nom variable] = [valor inicial];


### Literals
```c#
	bool  b = true;
	bool  bf = false;
	int i = 10;
	long lng = 1000L;
	ulong ulng = 10000UL;
	float f     = 10.4f; // f indica float
	double f = 10.4; // per defecte els nombres amb decimals s�n float.
	decimal d = 10.4M; // M de Money
	char c = 'A';
	
	
```
### Coma flotant o coma fixa 

Si useu double o float, useu representaci� en coma flotant. Aquesta representaci� permet treballar amb magnituds arbitr�riament grans o petites, per� duu associada una precisi�, que pot fer que el valor que s'emmagatzemi no sigui exactament el valor que voliem desar.
Si usem decimal, treballem an coma fixa. El llenguatge ens garanteix preservar fins a 29 digits sense p�rdua d'informaci�.
Aquest tipus de dades �s el que farem servir per representar valors monetaris.

### Infer�ncia de tipus: usant _var_
Podem "escaquejar-nos" de dir el tipus de dades, i deixar que sigui el compilador qui ho determini.
Aix� ho indiquem usant el tipus de dades  "var", que en realitat el que fa �s obligar el compilador a decidir autom�ticament el tipus de dades.

```c#
    var x = 25; // aix� �s equivalent a : int x = 25;
	var nom = "Paco";  // aix� equival a string nom ="Paco";
```
### Constants
Podem definir valors constants, que no es poden manipular posteriorment a la seva declaraci�. Cal inicialitzar la constant en la declaraci�.
```c#
	const int a = 100;
```
### Scope o �mbit de les variables
###  Variables locals i atributs. Valors per defecte
El compilador ens avisa si hi ha variables locals que s'utilitzen sense incialitzar.
Hi ha un tipus de variables "especials" anomenades atributs, molt diferent de les variables locals.  Recordeu que les variables locals "desapareixen" quan acaba la funci� que s'executa. Per contra, els atributs mantenen el seu valor mentre l'objecte on estan existeix.
La difer�ncia entre un atribut i una variable local �s el lloc on es declara:
```c#
    public sealed partial class MainPage : Page
    {
        int edat; // aix� �s un atribut

...

        private void btnBoto_Click(object sender, RoutedEventArgs e)
        {
            decimal preu; // aix� �s una variable local
			...

```
Els atributs si que es poden fer servir sense donar un valor inicial, doncs C# els inicialitza amb un valor per defecte segons el seu tipus de dades:
|     tipus             | valor per defecte |
|---------------------|----------------------|
| tipus num�rics  |            0             |
| tipus bool |            false             |
| tipus char |            car�cter 0             |
| tipus string  |            null             |
| tipus objecte  |            null             |
 
### 
### Conversions
Conversions a cadena ( des de qualsevol tipus )

### Treballant amb cadenes
Les cadenes s�n UNICODE ( per tant cada car�cter ocupa 16bits, i permeten representaci� universal de car�cters de la majoria de llenguatges exisitents ) 

 * Concatenaci�
Concatenem cadenes amb l'operador +
```c#
	string nom = "Josep " + "Maria";
	string nom_complet = nom + " L�pez";
 ```

 * Salt de l�nia
 Podem usar els literals "\n" o "\r\n"per representar el salt de l�nia:
 ```c#
	string dosLinies = "Primera L�nia\nSegona L�nia";
 ```
 �s millor utilitizar la seva representaci� gen�rica _Environment.NewLine_:
  ```c#
	string dosLinies = "Primera L�nia"+ Environment.NewLine + "Segona L�nia";
 ```
 * Autoreempla�ament
 Si prefixem la cadena amb un $, podem incrustar valors de variables dins de la cadena sense haver de fer concatenacions.
   ```c#
             string cadena = "M�n";
            string autoreempla� = $"Hola {cadena} ! ";
  ```
 * M�todes de conversi�
 Qualsevol tipus primitiu es pot convertir a cadena usant .toString()
 
 
 
 * M�todes de cerca, substituci� i trimming

