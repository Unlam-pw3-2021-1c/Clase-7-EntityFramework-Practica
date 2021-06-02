#  Clase-7-EntityFramework-Practica
## Enunciado
Utilizando lo visto durante la clase de teoria, desarrollar la funcionalidad para el Alta, Modificacion, Listado y Borrado  de Locales de prendas.

## Modelo de datos
## Prenda
|Tipo | Columna | Tipo de dato |
| ------ | ------ | ------ |
|PK| IdPrenda | int |
|| Talle | nvarchar(10) |
|| Color | nvarchar(100) |
|| Modelo | nvarchar(100) |
|| Marca | nvarchar(100) |
|FK| IdTipoPrenda | int |
|| Tela | nvarchar(100) |
|| Temporada | nvarchar(100) |

### TipoPrenda (Buzo, Pantalon, Remera)
|Tipo | Columna | Tipo de dato |
| ------ | ------ | ------ |
|PK| IdTipoPrenda | int |
|| Descripcion | nvarchar(100) |


### Local
|Tipo | Columna | Tipo de dato |
| ------ | ------ | ------ |
|PK| IdLocal | int |
|| Nombre | nvarchar(100) |
|| Direccion | nvarchar(200) |

### LocalPrenda
|Tipo | Columna | Tipo de dato |
| ------ | ------ | ------ |
|PK-FK| IdLocal | int |
|PK-FK| IdPrenda | int |
