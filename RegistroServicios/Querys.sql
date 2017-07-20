create view vUsers as
select u.idUsuario, u.Nombres +' '+ u.Apellidos as 'Nombre', u.Telefono, c.idCiudad, c.nombreCiudad
from Usuario u 
inner join Ciudad c on c.idCiudad = u.idCiudad