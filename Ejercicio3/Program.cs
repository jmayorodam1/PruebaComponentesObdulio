using Ejercicio3.Interfaces;
using Ejercicio3.Tipos;

namespace Ejercicio3
{
    public class Program
    {
        static void Main(string[] args)
        {
            FactoriaOrdenadores factoriaOrdenadores = new FactoriaOrdenadores();

            Ordenador Maria = new Ordenador();
            IGuardable guarfableMaria = factoriaOrdenadores.DameGuardable(TipoGuardable._789_XX);
            Maria.addIGuardable(guarfableMaria);

            IMemorizable memorizablemaria = factoriaOrdenadores.DameMemorizable(TipoMemorizable._879FH);
            Maria.addIMemorizable(memorizablemaria);

            IProcesable procesablemaria = factoriaOrdenadores.DameProcesable(TipoProcesador._789_XCS);
            Maria.addIProcesable(procesablemaria);


            Ordenador Andres = new Ordenador();

            IGuardable guarfableAndres = factoriaOrdenadores.DameGuardable(TipoGuardable._789_XX_3);
            Andres.addIGuardable(guarfableAndres);

            IMemorizable memorizableAndres = factoriaOrdenadores.DameMemorizable(TipoMemorizable._879FH_T);
            Andres.addIMemorizable(memorizableAndres);

            IProcesable procesableAndres = factoriaOrdenadores.DameProcesable(TipoProcesador._797_X3);
            Andres.addIProcesable(procesableAndres);




            Ordenador Tiburcioll = new Ordenador();

            IGuardable guarfableTiburcioll1 = factoriaOrdenadores.DameGuardable(TipoGuardable._789_XX);
            Tiburcioll.addIGuardable(guarfableTiburcioll1);

            IGuardable guarfableTiburcioll2 = factoriaOrdenadores.DameGuardable(TipoGuardable._788_fg);
            Tiburcioll.addIGuardable(guarfableTiburcioll2);

            IGuardable guarfableTiburcioll3 = factoriaOrdenadores.DameGuardable(TipoGuardable._1789_XCS);
            Tiburcioll.addIGuardable(guarfableTiburcioll3);


            IMemorizable memorizableTiburcioll1 = factoriaOrdenadores.DameMemorizable(TipoMemorizable._879FH);
            Tiburcioll.addIMemorizable(memorizableTiburcioll1);


            IProcesable procesableTiburcioll = factoriaOrdenadores.DameProcesable(TipoProcesador._789_XCS);
            Tiburcioll.addIProcesable(procesableTiburcioll);


            Ordenador AndresCF = new Ordenador();

            IGuardable guarfableAndresCF1 = factoriaOrdenadores.DameGuardable(TipoGuardable._788_fg);
            AndresCF.addIGuardable(guarfableAndresCF1);

            IGuardable guarfableAndresCF2 = factoriaOrdenadores.DameGuardable(TipoGuardable._789_XX_3);
            AndresCF.addIGuardable(guarfableAndresCF2);


            IMemorizable memorizableAndresCF = factoriaOrdenadores.DameMemorizable(TipoMemorizable._879FH_T);
            AndresCF.addIMemorizable(memorizableAndresCF);


            IProcesable procesableAndresCF = factoriaOrdenadores.DameProcesable(TipoProcesador._797_X3);
            AndresCF.addIProcesable(procesableAndresCF);

            int gradosAndresCF = AndresCF.gradosTotal;
            double precioAndresCF = AndresCF.precioTotal;

            Console.WriteLine("Los grados totales de este ordenador son: " + gradosAndresCF + " y su precio es de: " +precioAndresCF);
            
            Pedido pedidoA = new Pedido();

            pedidoA.add(Andres);
            pedidoA.add(Maria);

            Console.WriteLine("El precio del pedidoA es de: " + pedidoA.calcularPrecio() + " y los grados totales: " + pedidoA.calcularGrados());


            Pedido pedidoB = new Pedido();

            pedidoB.add(AndresCF);
            pedidoB.add(Tiburcioll);

            Console.WriteLine("El precio del pedidoB es de: " + pedidoB.calcularPrecio() + " y los grados totales: " + pedidoB.calcularGrados());


            Factura facturaA = new Factura();

            facturaA.add(pedidoA);

            Console.WriteLine("El precio del facturaA es de: " + facturaA.calcularPrecio() + " y los grados totales: " + facturaA.calcularGrados());


            Factura facturaB = new Factura();

            facturaB.add(pedidoB);

            Console.WriteLine("El precio del facturaB es de: " + facturaB.calcularPrecio() + " y los grados totales: " + facturaB.calcularGrados());


            Factura facturaC = new Factura();

            facturaC.add(pedidoA);
            facturaC.add(pedidoB);

            Console.WriteLine("El precio del facturaC es de: " + facturaC.calcularPrecio() + " y los grados totales: " + facturaC.calcularGrados());



        }

    }
}