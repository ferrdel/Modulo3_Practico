# Modulo3_Practico
Ejercicio Weather Forecast Súper Mejorado (para una Estación Meteorológica)

Utilizando el escenario del ejercicio anterior como base, deberás ahora reutilizar y reformar el código lo más que puedas para utilizar clases! 
Para ello deberás cumplir con las siguientes observaciones:

Observaciones:
En principio, todas las funciones de tu algoritmo deben ser métodos de clases. Puede que tengas que definir varias clases diferentes para funcionalidades diferentes, pero no deben quedar funciones sueltas. Puede que no utilices todas las funciones o código que hayas definido en tu escenario anterior, como el menú, por ej.
Deberás definir las clases que sean necesarias, con campos, propiedades, métodos, y modificadores de acceso que creas conveniente.
No es necesario que el proyecto sea de tipo consola, puedes usar si quieres una librería de clases, con todas las clases y funcionalidades necesarias para que yo lo implemente en otro proyecto, de ser necesario. (No es necesario el menú!).
Puedes definir más clases si así lo prefieres, no necesariamente deben estar sólo las clases que se piden en los requerimientos. Lo mismo con las propiedades y los métodos. Puedes definir más si así lo prefieres.
Deberás compartir todo en un repositorio! No más archivos ni texto para subir!
Bien, ahora vamos con los requerimientos (algunos nuevos!):

Requerimientos:
Se necesita saber ahora quién registró las temperaturas en qué día, sabiendo que en la estación está una persona presente en todo momento, pero esa persona puede ser un Profesional o bien un Pasante. No tienen mucha diferencias salvo que el pasante tiene un Número de Legajo, y el profesional tiene un Número de Matrícula que lo habilita. En total debería haber 3 pasantes y 3 profesionales, cubriendo turnos de 8 horas, y siempre intercalando Pasante-Profesional. Define las clases que creas necesario con sus respectivas properties. No es necesario que tenga métodos.
Deberás definir una clase llamada RegistroTemperatura, que contendrá la información de un registro de temperatura. Esta clase será usada ahora en la matriz. Estas podrían ser algunas properties:

-- Temperatura registrada
-- Persona de Turno
-- Fecha de registro
-- Hora de registro

Las colecciones deben ir en una clase llamada EstacionMeteorologica, con los siguientes métodos:

-- Un método llamado RegistrarTemperatura, que recibirá un objeto de tipo RegistroDemperatura, para ser almacenado en la matriz.
-- Un método VerTemperaturas, con parámetro para elegir qué colección ver. Este método puede devolver sólo las temperaturas.
-- Utiliza el constructor para la carga inicial de la matriz, si usaste carga automática.
-- Utiliza un método de carga para la matriz, si le pediste al usuario que cargue manualmente.
-- Puedes agregar algunas funciones anteriores como métodos de esta clase, como por ejemplo "Ver temperatura de un día específico". Tu eliges las que creas conveniente que pueden ir en esta clase.
-- Recuerda que ahora la matriz ya no es de tipo int, sino que almacena objetos de la clase nueva Registro! Modificalo!
Algunas funciones de cálculo de tu programa pueden ir en una clase estática, de nombre CalculoTemperaturas. Añade las funciones que creas convenientes que están relacionadas a algún tipo de cálculo del programa, como por ejemplo, CalcularTemperaturaPromedio o similares. Solo recuerda que estos métodos harán cálculo sobre algún parámetro que reciban de tipo de la colección seguramente. Puedes hacer uso de esta clase en EstaciónMeteorológica si así lo deseas, o bien dejarme a mi que la utilice si se te complica relacionarlas. Recuerda que esta clase será estática y la de estación no.
