# Punto 4
```
catch(Exception ex)
{
    throw;  
    throw new AlgunaExcepcion("mensaje de error 1", ex); 
    throw new AlgunaExcepcion("mensaje de error 2");
    throw ex;
}
```
- La primera linea `throw;` 