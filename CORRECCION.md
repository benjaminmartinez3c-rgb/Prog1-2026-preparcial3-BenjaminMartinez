# Correcciones — BenjaminMartinez

## Estructura del proyecto
- OK: `Prog1-2026-preparcial3-NombreApellido.sln` (nombre de template no reemplazado, pero estructura correcta).
- OK: Class Library (`LogicaNegocio`) + proyecto NUnit (`LogicaNegocio.Tests`).

---

## Punto 1 — Vehículos
- **MENOR**: `Vehiculo` está definida en `Class1.cs` en lugar de `Vehiculo.cs` — el nombre del archivo no corresponde a la clase.
- OK: `Vehiculo` es clase abstracta con método abstracto `CalcularPrecio(int horas)`.
- **ERROR**: las validaciones usan `throw new Exception(...)` en lugar de `throw new ArgumentException(...)`. Se espera la excepción específica.
- **MENOR**: la propiedad del propietario se llama `Nombre` en lugar de `NombrePropietario`.

## Punto 2 — Registro
- OK: ID con campo estático y pre-incremento (`ID = ++id`).
- OK: `ObtenerTotal()` delega en el vehículo.
- OK: validación de horas.

## Punto 3 — Servicio
- **ERROR**: `private List<Registro> registros` — debe ser `protected`.
- OK: búsqueda usa `.Trim().ToLower()` — funcional pero menos idiomático que `StringComparison.OrdinalIgnoreCase`.
- OK: retorna null si no hay registros.

## Punto 4 — Validaciones
- **ERROR**: usa `throw new Exception(...)` en lugar de `throw new ArgumentException(...)`.

## Punto 5 — Tests
- OK: 5+ tests, patrón AAA, verificaciones correctas.
- **ERROR**: las clases de test no tienen `[TestFixture]` — NUnit puede no reconocerlas.
- **MENOR**: nombres de tests no siguen la convención completa: `AutoElectrico_CalculaCorrecto` (falta el resultado esperado en el nombre).

---

## Puntajes

| Punto | Puntaje |
|---|---|
| P1 — Vehículos (25 pts) | 17/25 |
| P2 — Registro (15 pts) | 13/15 |
| P3 — Servicio (20 pts) | 11/20 |
| P4 — Validaciones (15 pts) | 8/15 |
| P5 — Tests (25 pts) | 13/25 |
| **Total** | **62/100** |

## Nota general

Solución funcional en su mayor parte: la jerarquía de herencia y la lógica de cálculo son correctas. Los errores más relevantes son el uso de `Exception` genérica en lugar de `ArgumentException` (punto explícito del enunciado), la lista del servicio `private` en vez de `protected`, y los tests sin `[TestFixture]`. Que `Vehiculo` esté en `Class1.cs` muestra que no se renombró el archivo generado por la plantilla. El nombre del `.sln` tampoco fue personalizado.
