<!-- markdownlint-disable-next-line MD041 MD033 -->
<img alt="UCU" src="https://www.ucu.edu.uy/plantillas/images/logo_ucu.svg"
width="150"/>

# Universidad Católica del Uruguay

## Programación II

# Desafío menú #2: Nuevas responsabilidades en el restaurante

## Objetivo

Asignar nuevas responsabilidades siguiendo las guías de diseño
[**Expert**](https://github.com/ucudal/PII_Principios_Patrones/blob/master/Expert.md)
y
[**SRP**](https://github.com/ucudal/PII_Principios_Patrones/blob/master/SRP.md).

El punto de partida es el ejercicio [Desafío menú
#1](https://github.com/ucudal/PII_Desafio_Menu_1_Start). En caso de que no lo
hayan completo, este repositorio contiene una posible solución a la que deberían
haber llegado.

> [!NOTE]
>
> Crea tu propio repositorio a partir de esta plantilla y clona ese repositorio
> en tu equipo.

<!-- Intentionally left blank -->

> [!IMPORTANT]
>
> Para compilar el código en Visual Studio Code ejecuten el comando `Run Build
> Task...` del menú `Terminal` y elijan `dotnet: build`.

<!-- Intentionally left blank -->

> [!TIP]
>
> Aunque todavía no vamos a ver cómo escribir ni ejecutar casos de prueba, este
> repositorio usa casos de prueba para que puedan comprobar su solución.
>
> Los casos de prueba están comentados para que la solución compile sin errores.
> Quita los comentarios que hay en
> [OrderTests.cs](./test/LibraryTests/OrderTests.cs) y
> [TableTests.cs](./test/LibraryTests/TableTests.cs).
>
> Una vez que ya no haya errores de compilación, ejecuta los casos de
> prueba usando el comando `Testing`  del menú `View` para mostrar el explorador
> de tests, y luego, haz como aparece a continuación:
>
> ![](/assets/RunTests.gif)

## Nuevas responsabilidades

<!-- Discute con tu equipo la consigna a continuación, pero impleméntala tú mismo. -->

### 1. Costo de los platillos ordenados

Aparece una nueva responsabilidad: conocer el costo total de los platillos que
se han ordenado en una mesa. El método para esa responsabilidad de hacer de ser
`double GetTotal()`. De acuerdo a la guía de diseño
[**Expert**](https://github.com/ucudal/PII_Principios_Patrones/blob/master/Expert.md),
¿qué clase debería tener esa responsabilidad?

Por ejemplo, el mozo debería saber lo que tiene que cobrar, ¿es razonable
agregar esa responsabilidad a la clase `Waiter`?

Implementa ese método en la clase en la que consideres que deba estar esa
responsabilidad.

### 2. Órdenes para llevar

Algo nuevo en el restaurante: órdenes para llevar. Las personas piden platillos
como si estuvieran sentados en una mesa, pero se los llevan a la casa.

Considera ahora el
[**SRP**](https://github.com/ucudal/PII_Principios_Patrones/blob/master/SRP.md).
Con este cambio, ¿todas las clases que hay hasta ahora tienen una sola razón de
cambio?

Haz las modificaciones que consideres necesarias para que el código siga al
mismo tiempo tanto lo que recomienda **Expert** como lo que recomienda **SRP**.

## Uso de ![GitHub Copilot](https://img.shields.io/badge/GitHub%20Copilot-000?logo=githubcopilot&logoColor=fff)

Es posible usar GitHub Copilot en este repositorio. Consulta [cómo usar Copilot
para aprender](./COPILOT.md).
