//VISOR DE PERSONAJES CON API DE RICK Y MORTY\\
Esta es una aplicación web construida con Blazor WebAssembly, esta permite visualizar a los personajes de la serie Rick y Morty, visualizar su información (Nombre, Especio, Estado, Foto, Puntaje...) también permite dar like
y dislike lo que deriva en su puntuación.

//DESCRIPCIÓN\\
Este proyecto es parte de una prueba tecnica para practicantes de desarrollo de software en CubiQ, como mencione anteriormente, es una galeria de los personajes de Rick y Morty.

//¿COMO EJECUTAR?\\

1. Clona el repositorio utilizando el siguiente link = https://github.com/Danimart22/Visor-de-Rick-y-Morty.git

2. Abre el proyecto en Visual Studio 2022

3. Establece como proyecto de inicio "VisordeRickyMorty"

4. Ejecuta la aplicación!

//¿COMO SE CONSUMIÓ LA API?\\

Para empezar, se utilizó la API publica de los personajes de Rick y Morty proveida por el documento de la prueba tecnica, en CharactersService hacemos la petición con HttpClient en la línea 19, ResponseCharacters
deserializa la propiedad "results" y así nos da la lista de los personajes.

//ESTRUCTURA DEL CODIGO\\

| Carpeta       | Archivo                          | Descripción                                  |
|---------------|----------------------------------|----------------------------------------------|
| `Pages/`      | `Index.razor`                    | Página principal que muestra los personajes  |
| `Components/` | `CharacterGallery.razor`         | Componente de tarjeta de personaje           |
| `Models/`     | `Character.cs`, `ResponseCharacters.cs` | Modelos de datos recibidos de la API  |
| `Services/`   | `CharactersService.cs`           | Servicio que consume la API de Rick & Morty  |
| `wwwroot/`    | `app.css`, `Bootstrap` (CDN)     | Archivos estáticos y estilos                 |

//FUNCIONALIDAD ADICIONALES\\
• Implementación de Bootstrap
• Responsive design

//DECISIONES TÉCNICAS\\

