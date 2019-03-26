# XamarinFlight
Segunda aplicacion de xamarin.
# Descripcion
En este proyecto vamos a realizar una aplicación para Android e IOS que debe componerse de:

- Splash -> Pantalla de carga con logotipo y bienvenida al usuario 
    - Dependiendo de la hora del día el saludo variará, Ej: Buenos días, Buenas tardes.

- Login -> Pantalla que carga el login del usuario:
    - Iniciar sesion
    - Recordar inicio de sesion -> Se guardará cifrado en preferencias.
    - Darse de alta como usuario nuevo.

- Registro:
    - Pantalla que contendrá un formulario de registro con datos del usuario.

- Pantalla principal -> Pantalla principal que mostrará las diferentes funcionalidades de la app
    - Buscador 
        - Podremos buscar los vuelos indicando un origen y un destino
    - Favoritos
        - Podremos ver nuestros vuelos guardados ( comprados )
    - Cercano -> Esta pantalla mostrará un mapa con los aeropuertos cercanos y nos mostrará los vuelos disponibles de dichos aeropuertos.
    - Perfil -> Pantalla que nos va a mostrar datos del usuario y cambiar ciertos parametros de configuración.

- Detalle del vuelo -> Al hacer click en un vuelo seleccionado podremos ver: mapa con origen y destino, los detalles del vuelo y realizar la compra del ticket.  

# Pantallas
- Las pantallas están en la carpeta screens.

# Estructura
- El proyecto debe ser un proyecto PLC de Xamarin,podeis bajaros el proyecto base, con la estructura básica en la rama master.

- Sería interesante que la estructura del proyecto sea lo más clara y limpia posible:
 - Nombre de clases intuitivas, organización en carpetas por funcionalidades
 - Codigo -> Intentar realizar un código limpio, respentando la nomenclatura, funciones con nombres intuitivos, etc...

- Una vez tengais vuestro proyecto creado, lo subireis mediante una pull request creando una rama con el contenido de vuestro proyecto por ejemplo: fran_solucion ( rama )

- Una vez finalizado esto podreís ver la rama que yo creare con la solución por mi parte para comparar y preguntar todas las dudas o cualquier otra cosa que querais comentar.

# Recursos:
- Los datos de los vuelos y demás se obtendrá de la web:  https://aviation-edge.com
  - Para consumir estos web services es requerida una api key.
- Los vuelos favoritos se almacenaran utilizando SQLite: sqlite-net-plc para Xamarin: https://docs.microsoft.com/es-es/xamarin/xamarin-forms/app-fundamentals/databases
- Google Maps Api: https://developers.google.com/maps/documentation/?hl=es
    - En este caso también se va a utilizar una api key.
- Firebase para dar de alta y realizar el proceso de login: https://firebase.google.com
