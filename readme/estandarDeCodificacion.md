# Estandar de desarrollo
## Introduccion
Este proyecto se desarrollará en C#  netframework para la comunicación en red se utilizará Windows communication foundatio y para la capa de presentación se utilizará Windows Presentation Foundation
## Proposito
El presente documento sirve como guía para los códigos fuentes del videojuego a realizar para la asignatura de Tecnologías para la construcción de software de la Facultad de Estadística e Informática. Tiene como propósito que la comunicación del equipo por medio del código sea efectiva. Busca unificar el código a escribir, así como dar una guía de la forma en que serán representados los distintos componentes del código.
Nombrado
## Nombrado
### Reglas generales
Todo el código fuente será escrito en el idioma inglés, incluyendo el nombre de métodos, atributos, propiedades.
Si las propiedades tienen modificadores de acceso públicos, serán escritos en notación UpperCammelCase.

### Propiedades
#### Bien
```csharp
public string FirstName{ get; set; }
```
#### Mal
```csharp
public string getFisrtName()
{
    return this.firstName;
}
```
### Metodos
Todos los metodos se escriben en UpperCammelCase
```csharp
public async SendMessage(string user, string message)
{
    await Clients.All.SendAsync("ReceiveMessage", user, message);
}
```
## Estilo
### Llaves
Cuando abrimos llaves en un metodo las llaves iran seguidos de un salto de linea en el metodo
#### Bien
```csharp
public CustomerDto ToDto()
{
    return new CustomerDto()
    {
        Address = Address,
        Email = Email,
        FirstName = FirstName,
        LastName = LastName,
        Phone = Phone,
        Id = Id ?? throw new Exception("el id no puede ser null")
    };
}
```
#### Mal
```csharp
public CustomerDto ToDto() {
    return new CustomerDto() {
        Address = Address,
        Email = Email,
        FirstName = FirstName,
        LastName = LastName,
        Phone = Phone,
        Id = Id ?? throw new Exception("el id no puede ser null")
    };
}
```
### Espaciados
Tiene que existir un espacio entre cada igual
#### Bien
```flag = true;```
#### Mal
```csharp
flag=true;
```