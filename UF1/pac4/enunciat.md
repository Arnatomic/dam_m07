
# Pr�ctica d'Acc�s a Dades

## Introducci�

El nostre client desitja construir una aplicaci� per gestionar el cat�leg de productes d'una botiga de roba, cal�at i complements.
L'analista, despr�s d'una reuni� amb el client, ha preparat una maqueta de les pantalles que cal crear inicialment. Sobre aquestes pantalles el client
valorar� si desitja continuar amb el projecte.

Per accelerar el proc�s de construcci� de l'aplicaci�, es construir� una maqueta que funcionar� amb una simple base de dades SQLite. M�s endavant caldria accedir a un servidor extern, per� aix� queda fora de l'�mbit d'aquesta pr�ctica.

Per facilitar-nos la feina, l'analista tamb� ens proporciona  un esquema relacional de la base de dades. Amb ell us ser� f�cil escriure un script SQL de creaci� de BD adaptat a la sintaxi SQLite. Tamb� caldr� que confeccioneu un script d'insercions per crear un joc de dades amb varies categories i productes. Aix� agilitzar� les vostres proves.

## Pantalles
Caldr� construir tres pantalles, dues es corresponen al Backoffice, que seria la gesti� de cat�leg que fa el propietari de la botiga, i l'altre al front-office, que equivaldria a la App que veuria el client.

### Backoffice > Gesti� del cat�leg
![Captura de pantalla](imatges/1.0_Backoffice_Gestio_de_cataleg.png "Maqueta de 'Backoffice > Gesti� del cat�leg'")

### Backoffice > Edici� i alta de productes
![Captura de pantalla](imatges/1.1_Backoffice_Edici�_Alta_de_producte.png "Maqueta de 'Backoffice > Edici� i alta de productes'")

### Frontoffice > Cat�leg de productes
![Captura de pantalla](imatges/2_Front Office_ Cataleg.png "Maqueta de 'Frontoffice > Cat�leg de productes'")



## Codi proporcionat 

Es proporciona el codi que permet obrir un selector d'arxius, llegir-lo i desar-lo
en un string.

```c#
		/// How to program a File Picker, and read the selected file
		/// into a string.
        private async void btnFile1_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker fp = new FileOpenPicker();
            fp.FileTypeFilter.Add(".txt");
            fp.FileTypeFilter.Add(".rtf");

            StorageFile sf = await fp.PickSingleFileAsync();
            string textReadFromFile = await readTextFile(sf);
            
			// ..... YOUR CODE HERE ...........
        }
		
		

        /// <summary>
        /// Read the storage file in text mode, returning it as string.
        /// Carriage return and line feed are supressed, and replaced by spaces.
        /// </summary>
        /// <param name="sf"></param>
        /// <returns></returns>
        private async Task<string> readTextFile(StorageFile sf)
        {
            StringWriter sw = new StringWriter();
            IRandomAccessStream stream = await sf.OpenAsync(FileAccessMode.Read);
            using (StreamReader streamReader = new StreamReader(stream.AsStream()))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    //txt += line + Environment.NewLine;
                    sw.Write(line + " ");
                }

                return sw.ToString();
            }
        }
		
```		