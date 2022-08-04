# Firebase Storage App

Poryecto que nos permite conectarnos a firebase storage

## Instalación y compilación

* .NET 5

### Librerias

* FirebaseAuthentication.net
* FirebaseStorage.net

### Archivo variables de entorno

Actualizar las siguientes variables del archivo  _Properties/launchSettings.json_

```json
"IIS Express": {
    "commandName": "IISExpress",
    "launchBrowser": true,
    "launchUrl": "swagger",
    "environmentVariables": {
    "ASPNETCORE_ENVIRONMENT": "Development",
    "API_KEY_STORAGE": "Your api key storage",
    "AUTH_EMAIL": "your email authentication ",
    "AUTH_PASWORD": "your password autenticaction",
    "BUCKET_STORAGE": "your bucket name"
    }
}
```

* *API_KEY_STORAGE*
* *AUTH_EMAIL*
* *AUTH_PASWORD*
* *BUCKET_STORAGE*