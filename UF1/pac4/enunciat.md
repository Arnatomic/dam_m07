
# Pr�ctica d'Acc�s a Dades

## Introducci�

El nostre client desitja construir una aplicaci� per gestionar el cat�leg de productes d'una botiga de roba, cal�at i complements.
L'analista, despr�s d'una reuni� amb el client, ha preparat una maqueta de les pantalles que cal crear inicialment. Sobre aquestes pantalles el client
valorar� si desitja continuar amb el projecte.

Per accelerar el proc�s de construcci� de l'aplicaci�, es construir� una maqueta que funcionar� amb una simple base de dades SQLite. M�s endavant caldria accedir a un servidor extern, per� aix� queda fora de l'�mbit d'aquesta pr�ctica.

Per facilitar-nos la feina, l'analista tamb� ens proporciona  un esquema relacional de la base de dades. Amb ell us ser� f�cil escriure un script SQL de creaci� de BD adaptat a la sintaxi SQLite. Tamb� caldr� que confeccioneu un script d'insercions per crear un joc de dades amb varies categories i productes. Aix� agilitzar� les vostres proves.

## Pantalles
Caldr� construir tres pantalles, dues es corresponen al Backoffice, que seria la gesti� de cat�leg que fa el propietari de la botiga, i l'altre al front-office, que equivaldria a la App que veuria el client.

### P�gina 1.0 / Backoffice > Gesti� del cat�leg
![Captura de pantalla](imatges/1.0_Backoffice_Gestio_de_cataleg.png "Maqueta de 'Backoffice > Gesti� del cat�leg'")
En aquesta pantalla l'administrador pot llistar els productes, fer cerques, esborrar, crear i editar nous productes. L'edici� i la inserci� es fan la p�gina 1.1

### P�gina 1.1 / Backoffice > Edici� i alta de productes
![Captura de pantalla](imatges/1.1_Backoffice_Edici�_Alta_de_producte.png "Maqueta de 'Backoffice > Edici� i alta de productes'")
La pantalla permet editar i donar d'alta productes. Cada producte t� m�ltiples camps, i cal assegurar la integritat de les dades abans de poder desar els canvis. L'aplicaci� marcar� en tot moment els camps que resten per completar o que tenen dades incorrectes ( mostreu un missatge o una icona al costat del camp erroni, i useu un color de fons al control per indicar que �s erroni/incomplet )
Per tal que un producte sigui correcte cal que:
* tots els camps obligatoris estiguin degudament complimentats
* que hi hagi com a m�nim un color
* que hi hagi com a m�nim una foto per a cada color.

### P�gina 2.0 / Frontoffice > Cat�leg de productes
![Captura de pantalla](imatges/2_Front Office_ Cataleg.png "Maqueta de 'Frontoffice > Cat�leg de productes'")



## Model de base de dades
A continuaci� es mostra la base de dades que caldr� fer servir per l'aplicaci�.
Tingueu especial cura amb:
* els tipus de dades
* els camps obligatoris/opcionals
* les claus prim�ries (PK)
* les claus foranes  (FK)
* les claus alternatives (AK) 

Tingueu en compte que la taula de productes haur� de tenir el camp prod_id autonum�ric per facilitar l'inserci� de registres.
La taula _color_ �s feble de _producte_, mentre que _foto_ �s feble de _color_. Els camps *_num s�n ordinals que han de comptar les ocurr�ncies.

L'arbre de categories es munta de forma reflexiva, on cada categoria apunta a una categoria pare. La categoria arrel no apunta a cap (NULL)

![Captura de pantalla](imatges/base_de_dades.png.png "Model de base de dadse'")


