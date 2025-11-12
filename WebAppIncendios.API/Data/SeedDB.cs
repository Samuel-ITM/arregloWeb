using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppIncendios.API.Data;
using WebAppIncendios.shared.Entidades;
using WebAppIncendios.Shared.Entidades;

namespace WebAppIncendios.API.Data
{
    public class SeedDb
    {
        private readonly ApplicationDbContext _context;

        public SeedDb(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckRolesAsync();
            await CheckUsuariosAsync();
            await CheckProveedoresAsync();
            await CheckProductosAsync();
        }

        private async Task CheckRolesAsync()
        {
            if (!_context.Roles.Any())
            {
                _context.Roles.AddRange(
                    new Rol { Nombre = "Administrador", Descripcion = "Acceso total al sistema" , NivelAcceso = 10, Activo = true},
                    new Rol { Nombre = "Técnico", Descripcion = "Gestiona citas y reportes", NivelAcceso = 5, Activo = true }
                );
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckUsuariosAsync()
        {
            if (!_context.Empleados.Any())
            {
                _context.Empleados.AddRange(
                    new Empleado { Nombre = "Juan Pérez", Correo = "admin@redfire.com", Telefono = "201 555 0123" ,Estado = "Activo" ,RolId = 1 },
                    new Empleado { Nombre = "Laura Gómez", Correo = "laura@redfire.com", Telefono = "216 329 6012", Estado = "Activo" ,RolId = 2 },
                    new Empleado { Nombre = "Carlos Ruiz", Correo = "carlos@redfire.com", Telefono = "600 201 2345", Estado = "Activo" ,RolId = 2 }
                );
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckProveedoresAsync()
        {
            if (!_context.Proveedores.Any())
            {
                _context.Proveedores.AddRange(
                    new Proveedor { Nombre = "FireEquip Ltda", Telefono = "321 987 6543", Correo = "contacto@fireequip.com", Direccion = "Bogotá, Colombia" },
                    new Proveedor { Nombre = "ProSegur Safety", Telefono = "310 123 4567", Correo = "ventas@prosegur.com", Direccion = "Medellín, Colombia" }
                );
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckProductosAsync()
        {
            if (!_context.Dispositivos.Any())
            {
                _context.Dispositivos.AddRange(
                    new Dispositivo { Nombre = "Extintor ABC 10lb", Tipo = "Extintor", Precio = 250000, Stock = 50, IdProveedor = 1 },
                    new Dispositivo { Nombre = "Bomba contra incendio 2HP", Tipo = "Rociador", Precio = 1850000, Stock = 10, IdProveedor = 1 },
                    new Dispositivo { Nombre = "Alarma de humo inalámbrica", Tipo = "Alarma", Precio = 120000, Stock = 40, IdProveedor = 2 },
                    new Dispositivo { Nombre = "Válvula de control de 4”", Tipo = "Sensor de humo", Precio = 350000, Stock = 20, IdProveedor = 2 }
                );
                await _context.SaveChangesAsync();
            }
        }
    }
}
