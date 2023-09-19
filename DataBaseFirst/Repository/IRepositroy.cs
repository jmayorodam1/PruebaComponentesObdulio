using DataBaseFirst.Models;

namespace DataBaseFirst.Repository
{
    public interface IRepositroy
    {
        Componente ObtenerComponentePorId(int id);

        List<Componente> ObtenerTodosComponente();

        void AgregarComponente(Componente componente);

        void ActualizarComponente(Componente componente);

        void EliminarComponente(int id);



        Ordenador ObtenerOrdenadorPorId(int id);

        List<Ordenador> ObtenerTodosOrdenadores();

        void AgregarOrdenador(Ordenador ordenador);

        void ActualizarOrdenador(Ordenador ordenador);

        void EliminarOrdenador(int id);



        Factura ObtenerOrdenadoresFacturaPorId(int id);

        List<Factura> ObtenerTodosFacturas();

        void AgregarFactura(Factura factura);

        void ActualizarFactura(Factura factura);

        void EliminarFactura(int id);



        OrdenadoresFactura ObtenerOrdenadorFacturaPorId(int id);

        List<OrdenadoresFactura> ObtenerTodosOrdenadorFactura();

        void AgregarOrdenadoresFactura(OrdenadoresFactura factura);

        void ActualizarOrdenadoresFactura(OrdenadoresFactura factura);

        void EliminarOrdenadoresFactura(int id);



        OrdenadorComponente ObtenerOrdenadorComponentePorId(int id);

        List<OrdenadorComponente> ObtenerTodosOrdenadorComponente();


        void AgregarOrdenadorComponente(OrdenadorComponente factura);

        void EliminarOrdenadorComponente(int id);

        void ActualizarOrdenadorComponente(OrdenadorComponente factura);
    }
}
